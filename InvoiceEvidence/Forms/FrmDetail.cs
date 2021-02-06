using InvoiceEvidenceLib;
using System.Windows.Forms;

namespace InvoiceEvidence.Forms
{
  public partial class FrmDetail : Form
  {
    public FrmDetail()
    {
      InitializeComponent();
    }

    public Invoice Invoice
    {
      get => invoiceDetail.Invoice;
      set
      {
        value.AppendEmptyItems();
        invoiceDetail.Invoice = value;
      }

    }

    private void FrmDetail_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.Invoice.DiscardEmptyItems();
    }
  }
}
