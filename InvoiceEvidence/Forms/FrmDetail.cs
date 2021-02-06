using InvoiceEvidenceLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      get => this.invoiceDetail.Invoice;
      set => this.invoiceDetail.Invoice = value;
    }
  }
}
