using InvoiceEvidenceLib;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  public partial class InvoiceRow : UserControl
  {
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
  }
}
