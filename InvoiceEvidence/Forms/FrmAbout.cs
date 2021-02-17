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
  public partial class FrmAbout : Form
  {
    public FrmAbout()
    {
      InitializeComponent();
    }

    private void FrmAbout_Load(object sender, EventArgs e)
    {
      lblTitle.Text = Application.ProductName;
      lblVer.Text = "ver.: " + Application.ProductVersion.ToString();
      lblAuthor.Text = Application.CompanyName;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
