using InvoiceEvidenceLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceEvidence.Forms
{
  public partial class FrmNewInvoice : Form
  {
    class ListBoxItem
    {
      public Invoice Value { get; set; }
      public string Label { get => Value.FileName; }
      public bool Ignored { get; set; }
      public override string ToString() => Ignored ? "[ignored] " + Label : Label;
    }

    private List<ListBoxItem> fileItems = new List<ListBoxItem>();
    private ListBoxItem _Item = null;
    private ListBoxItem Item
    {
      get => _Item;
      set
      {
        _Item = value;
        if (value == null)
        {
          splMain.Panel2.Visible = false;
        }
        else
        {
          splMain.Panel2.Visible = true;
          invoceDetail.Invoice = value.Value;
        }

      }
    }

    private List<string> _IgnoredFiles = new List<string>();
    public List<string> IgnoredFiles
    {
      get => _IgnoredFiles;
      set => _IgnoredFiles = value ?? new List<string>();
    }

    public FrmNewInvoice()
    {
      InitializeComponent();
    }

    private void FrmNewInvoice_Load(object sender, EventArgs e)
    {
      splMain.Panel2.Visible = false;
      RefreshFilesList();
      invoceDetail.RecognitionEnabled = true;
    }

    private void RefreshFilesList(int presetIndex = -1)
    {
      fileItems = Directory.GetFiles(Program.DbPath)
        .Where(q => q.Length > 4 && IsFileNameWithAcceptedExtension(q))
        .Select(q => new FileInfo(q))
        .Where(q => !Program.Invoices.Any(r => r.FileName == q.Name))
        .OrderBy(q => q.Name)
        .Select(q => new ListBoxItem()
        {
          Value = new Invoice(q.Name, 7),
          Ignored = IgnoredFiles.Contains(q.Name)
        })
        .ToList();

      if (chkShowIgnored.Checked == false)
        fileItems = fileItems
          .Where(q => IgnoredFiles.Contains(q.Value.FileName) == false)
          .ToList();

      lstFiles.DataSource = fileItems;

      if (presetIndex >= 0 && fileItems.Count > 0 && presetIndex < fileItems.Count)
        lstFiles.SelectedIndex = presetIndex;
    }

    private bool IsFileNameWithAcceptedExtension(string fileName)
    {
      bool ret = Program.AppSettings.SupportedExtension.Split(';').Any(q => fileName.EndsWith(q));
      return ret;
    }

    private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstFiles.SelectedIndex < 0)
      {
        Item = null;
      }
      else
      {
        Item = lstFiles.SelectedItem as ListBoxItem;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Item.Value.DiscardEmptyItems();
      Program.Invoices.Add(Item.Value);
      int index = lstFiles.SelectedIndex;

      lstFiles.DataSource = null;
      fileItems.RemoveAt(index);
      RefreshFilesList(index);
    }

    private void toggleIgnoredToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Item == null) return;

      if (IgnoredFiles.Contains(Item.Value.FileName))
        IgnoredFiles.Remove(Item.Value.FileName);
      else
        IgnoredFiles.Add(Item.Value.FileName);

      RefreshFilesList(lstFiles.SelectedIndex);
    }

    private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RefreshFilesList(lstFiles.SelectedIndex);
    }

    private void chkShowIgnored_CheckedChanged(object sender, EventArgs e)
    {
      RefreshFilesList();
    }
  }
}
