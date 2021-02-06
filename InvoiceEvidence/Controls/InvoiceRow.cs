using InvoiceEvidenceLib;
using System.Windows.Forms;

namespace InvoiceEvidence.Controls
{
  public partial class InvoiceRow : UserControl
  {
    public delegate void ViewButtonClickedDelegate(InvoiceRow sender);
    public event ViewButtonClickedDelegate ViewButtonClicked;

    public InvoiceRow()
    {
      InitializeComponent();
    }

    private Invoice _Invoice;
    public Invoice Invoice
    {
      get => _Invoice;
      set
      {
        _Invoice = value;
        invoiceBindingSource.DataSource = value;
      }
    }

    private void btnView_Click(object sender, System.EventArgs e)
    {
      ViewButtonClicked?.Invoke(this);
    }
  }
}
