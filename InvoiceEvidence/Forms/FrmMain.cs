using InvoiceEvidenceLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void btnAnalyseNewFiles_Click(object sender, EventArgs e)
    {
      new FrmNewInvoice().ShowDialog();
      RefreshView();
    }

    private void RefreshView()
    {
      pnlItems.Controls.Clear();

      foreach (var invoice in Program.Invoices)
      {
        InvoiceRow row = new InvoiceRow()
        {
          Invoice = invoice
        };
        row.Width = pnlItems.Width - 24;
        row.BorderStyle = BorderStyle.FixedSingle;
        pnlItems.Controls.Add(row);
      }
    }

    private void btnChangeFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      fbd.SelectedPath = Program.DbPath;
      fbd.ShowNewFolderButton = true;

      if (fbd.ShowDialog() == DialogResult.OK)
      {
        Program.DbPath = fbd.SelectedPath;
        ReloadDatabase();
      }
    }

    private void btnReload_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Reload data from storage?",
        "Reload database",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        ReloadDatabase();
    }

    private void ReloadDatabase()
    {
      if (File.Exists(Program.DbFile) == false)
      {
        MessageBox.Show("Unable to find database file in the working folder. No data loaded.",
          "Unable to find database.",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        return;
      }
      using (StreamReader rdr = new StreamReader(File.Open(Program.DbFile, FileMode.Open)))
      {
        JsonSerializer ser = new JsonSerializer();
        List<Invoice> tmp = (List<Invoice>)ser.Deserialize(rdr, typeof(List<Invoice>));
        Program.Invoices = tmp;
      }
      RefreshView();

      this.Text = $"Invoice Evidence [{Program.DbPath}]";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveDatabase();
    }

    private void SaveDatabase()
    {
      string tmpFile = Path.GetTempFileName();

      using (StreamWriter wrt = new StreamWriter(File.Open(tmpFile, FileMode.Create)))
      {
        JsonSerializer ser = new JsonSerializer();
        ser.Serialize(wrt, Program.Invoices);
      }

      File.Copy(tmpFile, Program.DbFile, true);

      MessageBox.Show("Database file saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      ReloadDatabase();
    }
  }
}
