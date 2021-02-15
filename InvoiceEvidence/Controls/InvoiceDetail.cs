using InvoiceEvidenceLib;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace InvoiceEvidence.Controls
{
  public partial class InvoiceDetail : UserControl
  {
    public bool RecognitionEnabled
    {
      get => picInvoice.RecognitionEnabled;
      set => picInvoice.RecognitionEnabled = value;
    }

    private object lastControl = null;
    private Image pdfExtractedImage = null;



    private Invoice _Invoice;
    public Invoice Invoice
    {
      get => _Invoice;
      set
      {
        _Invoice = value;
        if (value != null)
        {
          invoiceBindingSource.DataSource = value;
          picInvoice.SetImageFile(
            System.IO.Path.Combine(Program.DbPath, value.FileName));
          picInvoice.ZoomFit();
        }
        else
          picInvoice.ClearImageFile();
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

    public InvoiceDetail()
    {
      InitializeComponent();
      picInvoice.BlockTextRecognized += PicInvoice_BlockTextRecognized;
    }

    private void InoviceDetail_Load(object sender, EventArgs e)
    {
      picInvoice.BlockTextRecognized += PicInvoice_BlockTextRecognized;
    }

    private void ctr_Enter(object sender, EventArgs e)
    {
      lastControl = sender;
    }

    private void PicInvoice_BlockTextRecognized(InvoiceImage sender, string text)
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
  }
}
