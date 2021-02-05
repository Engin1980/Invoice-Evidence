using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoceEvidenceLib;

namespace InvoiceEvidence
{
  public partial class InvoceRow : UserControl
  {
    public InvoceRow()
    {
      InitializeComponent();
    }

    private Invoce _Invoce;
    public Invoce Invoce
    {
      get => this._Invoce;
      set
      {
        this._Invoce = value;
        this.invoceBindingSource.DataSource = value;
      }
    }
  }
}
