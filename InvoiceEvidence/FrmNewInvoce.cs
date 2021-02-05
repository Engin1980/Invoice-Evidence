using InvoceEvidenceLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  public partial class FrmNewInvoce : Form
  {
    class ListBoxItem
    {
      public Invoce Value { get; set; }
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
        } else
        {
          splMain.Panel2.Visible = true;
          invoceBindingSource.DataSource = value.Value;
        }
        
      }
    }

    private string[] imageExtensions = { ".png", ".jpg", ".bmp" };

    public FrmNewInvoce()
    {
      InitializeComponent();
      invoceBindingSource.DataSourceChanged += InvoceBindingSource_DataSourceChanged;
      picInvoce.BlockTextRecognized += PicInvoce_BlockTextRecognized;
    }

    object lastControl = null;

    private void PicInvoce_BlockTextRecognized(InvoceImage sender, string text)
    {
      if (text != null) text = text.Trim();
      if (lastControl != null)
      {
        if (lastControl is TextBox)
        {
          var txt = lastControl as TextBox;
          txt.Text = text;
          txt.SelectionStart = txt.Text.Length;
          txt.SelectionLength = 0;
        }
        else if (lastControl is DateTimePicker)
        {
          var dtp = lastControl as DateTimePicker;
          DateTime? dt = TryConvertDateFromString(text);
          if (dt != null)
            dtp.Value = dt.Value;
        }
        else if (lastControl is NumericUpDown)
        {
          var nud = lastControl as NumericUpDown;
          double? value = TryParseNumberFromString(text);
          if (value != null)
            nud.Value = (decimal)value.Value;
        }
        else if (lastControl is DataGridView)
        {
          var grd = lastControl as DataGridView;

          var currentCell = grd.CurrentCell;
          if (currentCell.ColumnIndex == 1)
          {
            double? value = TryParseNumberFromString(text);
            if (value != null) currentCell.Value = value;
          }
          else
          {
            currentCell.Value = text.Trim();
          }
          grd.RefreshEdit();
          grd.Refresh();
        }
      }
    }

    private DateTime? TryConvertDateFromString(string text)
    {
      CultureInfo cultureInfo = CultureInfo.CurrentCulture;

      string[] patterns = { "d. M. yyyy", "d.M.yyyy", "d. MMMM yyyy" };
      DateTime? ret = null;
      DateTime tmp;
      foreach (var pattern in patterns)
      {
        if (DateTime.TryParseExact(text, patterns, cultureInfo, DateTimeStyles.None, out tmp))
        {
          ret = tmp;
          break;
        }
      }
      if (ret == null)
      {
        if (DateTime.TryParse(text, out tmp))
          ret = tmp;
      }

      return ret;
    }

    private double? TryParseNumberFromString(string text)
    {
      double? ret;
      try
      {
        ret = double.Parse(text);
      }
      catch
      {
        try
        {
          ret = double.Parse(text, CultureInfo.GetCultureInfo("en-US"));
        }
        catch
        {
          ret = null;
        }
      }
      return ret;
    }

    private void InvoceBindingSource_DataSourceChanged(object sender, EventArgs e)
    {
      //RedrawImage();
    }

    private void FrmNewInvoce_Load(object sender, EventArgs e)
    {
      splMain.Panel2.Visible = false;
      RefreshFilesList();
    }

    private void RefreshFilesList(int presetIndex = -1)
    {
      fileItems = System.IO.Directory.GetFiles(Program.DbPath)
        .Where(q => q.Length > 4 && imageExtensions.Contains(q.Substring(q.Length - 4)))
        .Select(q => new FileInfo(q))
        .Where(q => !Program.Invoces.Any(r => r.FileName == q.Name))
        .OrderBy(q => q.Name)
        .Select(q => new ListBoxItem() { Value = new Invoce(q.Name, 7) })
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
        picInvoce.ClearImageFile();
      }
      else
      {
        Item = lstFiles.SelectedItem as ListBoxItem;
        picInvoce.SetImageFile(
          System.IO.Path.Combine(Program.DbPath, Item.Value.FileName));
      }
    }

    private void ctr_Enter(object sender, EventArgs e)
    {
      lastControl = sender;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Item.Value.DiscardEmptyItems();
      Program.Invoces.Add(Item.Value);
      int index = lstFiles.SelectedIndex;

      lstFiles.DataSource = null;
      fileItems.RemoveAt(index);
      RefreshFilesList(index);
    }
  }
}
