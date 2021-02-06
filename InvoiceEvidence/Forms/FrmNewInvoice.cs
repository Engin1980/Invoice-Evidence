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
      public override string ToString() => Label;
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

    private string[] imageExtensions = { ".png", ".jpg", ".bmp" };

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
      fileItems = System.IO.Directory.GetFiles(Program.DbPath)
        .Where(q => q.Length > 4 && imageExtensions.Contains(q.Substring(q.Length - 4)))
        .Select(q => new FileInfo(q))
        .Where(q => !Program.Invoices.Any(r => r.FileName == q.Name))
        .OrderBy(q => q.Name)
        .Select(q => new ListBoxItem() { Value = new Invoice(q.Name, 7) })
        .ToList();

      lstFiles.DataSource = fileItems;

      if (presetIndex >= 0 && fileItems.Count > 0 && presetIndex < fileItems.Count)
        lstFiles.SelectedIndex = presetIndex;
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
  }
}
