using InvoiceEvidenceLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

      List<Invoice> invoices = GetOrderedAndFilteredInvoices();

      foreach (var invoice in invoices)
      {
        InvoiceRow row = new InvoiceRow()
        {
          Invoice = invoice
        };
        row.Width = pnlItems.Width - VERTICAL_SCROLLBAR_PLACEHOLDER_WIDTH;
        row.BorderStyle = BorderStyle.FixedSingle;
        if (chkColorize.Checked)
          row.BackColor = GetBackColorForInvoice(invoice);
        pnlItems.Controls.Add(row);

      }
    }

    private Color GetBackColorForInvoice(Invoice invoice)
    {
      TimeSpan ts = DateTime.Now - invoice.Date;
      if (ts.TotalDays > (365 * 2))
        // old ones
        return System.Drawing.Color.FromArgb(200, 100, 100);
      else if (ts.TotalDays < 14)
        return Color.White;
      else
        return System.Drawing.SystemColors.Control;
    }

    private List<Invoice> GetOrderedAndFilteredInvoices()
    {
      IEnumerable<Invoice> ret;

      string quickQuery = txtQuickFilter.Text.Trim();
      if (quickQuery.Length > 0)
      {
        ret = Program.Invoices.Where(q =>
             q.Keywords.ToLower().Contains(quickQuery)
          || q.ItemsOverview.ToLower().Contains(quickQuery)
          || q.Number.ToLower().Contains(quickQuery)
          || q.OrderNumber.ToLower().Contains(quickQuery)
          || q.ShopName.ToLower().Contains(quickQuery));
      }
      else
      {
        ret = Program.Invoices;
      }

      switch (cmbOrderBy.SelectedIndex)
      {
        case 0:
          ret = ret.OrderByDescending(q => q.Date);
          break;
        case 1:
          ret = ret.OrderBy(q => q.Number);
          break;
        case 2:
          ret = ret.OrderBy(q => q.ShopName);
          break;
        case 3:
          ret = ret.OrderBy(q => q.TotalPrice);
          break;
        case 4:
          ret = ret.OrderByDescending(q => q.TotalPrice);
          break;
      }

      return ret.ToList();
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

      Text = $"Invoice Evidence [{Program.DbPath}]";
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

    private void txtQuickFilter_TextChanged(object sender, EventArgs e)
    {
      RefreshView();
    }

    private void cmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
    {
      RefreshView();
    }

    private void FrmMain_ResizeEnd(object sender, EventArgs e)
    {
      foreach (Control control in pnlItems.Controls)
      {
        control.Width = pnlItems.Width - VERTICAL_SCROLLBAR_PLACEHOLDER_WIDTH;
      }
    }

    private const int VERTICAL_SCROLLBAR_PLACEHOLDER_WIDTH = 32;

    private void chkColorize_CheckedChanged(object sender, EventArgs e)
    {
      RefreshView();
    }
  }
}
