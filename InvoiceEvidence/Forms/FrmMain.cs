using InvoiceEvidence.Controls;
using InvoiceEvidenceLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
      var f = new FrmNewInvoice
      {
        IgnoredFiles = Program.Db.IgnoredFiles
      };
      f.ShowDialog();
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
      fbd.Description = "Select folder with invoices (images or PDFs):";

      if (fbd.ShowDialog() == DialogResult.OK)
      {
        Program.DbPath = fbd.SelectedPath;
        ReloadDatabase();

        Properties.Settings.Default.LastDatabaseFolder = Program.DbPath;
        Properties.Settings.Default.Save();
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
        Db db = (Db)ser.Deserialize(rdr, typeof(Db));
        Program.Db = db;
      }
      if (string.IsNullOrEmpty(Program.Db.RelativePath) == false &&
        Program.DbPath != Program.Db.RelativePath)
      {
        MessageBox.Show($"Note that the last stored path for this database file was '{Program.Db.RelativePath}'. " +
           " Proceed with caution.", "Database path mismatch!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      RefreshView();

      Text = $"Invoice Evidence [{Program.DbPath}]";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveDatabase(out bool success);
    }

    private void SaveDatabase(out bool success)
    {
      Program.Db.RelativePath = Program.DbPath;

      string tmpFile = Path.GetTempFileName();
      try
      {
        string jsonText = JsonConvert.SerializeObject(Program.Db, Formatting.Indented);
        File.WriteAllText(tmpFile, jsonText);
        File.Copy(tmpFile, Program.DbFile, true);
        MessageBox.Show("Database file saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        success = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Failed to save the database. {ex.Message}", "Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        success = false;
      }
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      cmbOrderBy.SelectedIndex = 0;
      if (string.IsNullOrEmpty(Program.DbPath))
      {
        btnChangeFolder_Click(null, null);
      }
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

    private void grdItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      Invoice invoice = visibleInvoices[e.RowIndex];
      FrmDetail frm = new FrmDetail
      {
        Invoice = invoice
      };
      frm.ShowDialog();
      RefreshView();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      var res = MessageBox.Show(this, "You are closing the application. All unsaved changes will be lost." +
        "Would you like to save the invoices database now?",
        "Save changes?",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);

      if (res == DialogResult.Cancel)
      {
        e.Cancel = true;
        return;
      }
      else if (res == DialogResult.Yes)
      {
        bool success;
        SaveDatabase(out success);
        if (!success)
        {
          e.Cancel = true;
          return;
        }
      }

      EIO.DoDeleteOnExit();
    }

    private void txtQuickFilter_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        txtQuickFilter.Text = "";
        e.Handled = true;
      }
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
      new FrmAbout().ShowDialog();
    }
  }
}
