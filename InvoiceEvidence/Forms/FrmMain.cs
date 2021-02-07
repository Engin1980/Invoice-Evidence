using InvoiceEvidence.Controls;
using InvoiceEvidence.Forms;
using InvoiceEvidenceLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceEvidence.Forms
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
      pnlItems.Dock = DockStyle.Fill;
      grdItems.Dock = DockStyle.Fill;
    }

    private void btnAnalyseNewFiles_Click(object sender, EventArgs e)
    {
      new FrmNewInvoice().ShowDialog();
      RefreshView();
    }

    private void RefreshView()
    {
      if (Properties.Settings.Default.MainFormExtendedView)
      {
        grdItems.Visible = false;
        pnlItems.Visible = true;
        RefreshViewViaUserControl();
      }
      else
      {
        grdItems.Visible = true;
        pnlItems.Visible = false;
        RefreshViewViaDataGridView();
      }
    }

    List<Invoice> visibleInvoices;

    private void RefreshViewViaDataGridView()
    {
      visibleInvoices = GetOrderedAndFilteredInvoices();
      grdItems.DataSource = visibleInvoices;
    }

    private void RefreshViewViaUserControl()
    {
      pnlItems.Controls.Clear();

      visibleInvoices = GetOrderedAndFilteredInvoices();

      foreach (var invoice in visibleInvoices)
      {
        InvoiceRow row = new InvoiceRow()
        {
          Invoice = invoice,
        };
        row.ViewButtonClicked += Row_ViewButtonClicked;
        row.Width = pnlItems.Width - VERTICAL_SCROLLBAR_PLACEHOLDER_WIDTH;
        row.BorderStyle = BorderStyle.FixedSingle;
        if (chkColorize.Checked)
          row.BackColor = GetBackColorForInvoice(invoice);
        pnlItems.Controls.Add(row);

      }
    }

    private void Row_ViewButtonClicked(InvoiceRow sender)
    {
      FrmDetail frm = new FrmDetail
      {
        Invoice = sender.Invoice
      };
      frm.ShowDialog();
      RefreshView();
    }

    private Color GetBackColorForInvoice(Invoice invoice)
    {
      TimeSpan ts = DateTime.Now - invoice.Date;
      if (ts.TotalDays > Properties.Settings.Default.InvoiceOldDaysCount)
        // old ones
        return Properties.Settings.Default.InvoiceOldBackColor;
      else if (ts.TotalDays < Properties.Settings.Default.InvoiceNewDaysCount)
        return Properties.Settings.Default.InvoiceNewBackColor;
      else
        return SystemColors.Control;
    }

    private List<Invoice> GetOrderedAndFilteredInvoices()
    {
      IEnumerable<Invoice> ret;

      string quickQuery = txtQuickFilter.Text.Trim();
      if (quickQuery.Length > 0)
      {
        ret = Program.Invoices.Where(q => IsQuickQueryMatch(q, quickQuery));
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

    private bool IsQuickQueryMatch(Invoice q, string pattern)
    {
      bool ret = IsQuickStringMatch(pattern, q.Keywords)
        || IsQuickStringMatch(pattern, q.ItemsOverview)
        || IsQuickStringMatch(pattern, q.Number)
        || IsQuickStringMatch(pattern, q.OrderNumber)
        || IsQuickStringMatch(pattern, q.ShopName);

      return ret;
    }

    private bool IsQuickStringMatch(string pattern, string content)
    {
      return content != null && content.ToLower().Contains(pattern);
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

      string jsonText = JsonConvert.SerializeObject(Program.Invoices, Formatting.Indented);

      System.IO.File.WriteAllText(tmpFile, jsonText);

      File.Copy(tmpFile, Program.DbFile, true);

      MessageBox.Show("Database file saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      cmbOrderBy.SelectedIndex = 0;
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

    private static readonly int VERTICAL_SCROLLBAR_PLACEHOLDER_WIDTH = Properties.Settings.Default.MainFormVerticalScrollbarPlaceholderWith;

    private void chkColorize_CheckedChanged(object sender, EventArgs e)
    {
      RefreshView();
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      new FrmSettings().ShowDialog();
    }

    private void grdItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      if (chkColorize.Checked == false || visibleInvoices == null) return;

      for (int i = 0; i < visibleInvoices.Count; i++)
      {
        Color c = GetBackColorForInvoice(visibleInvoices[i]);
        grdItems.Rows[i].DefaultCellStyle.BackColor = c;
      }
    }
  }
}
