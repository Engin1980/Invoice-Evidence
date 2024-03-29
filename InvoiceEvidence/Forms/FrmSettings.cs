﻿using System;
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
  public partial class FrmSettings : Form
  {
    public FrmSettings()
    {
      InitializeComponent();
    }

    private void FrmSettings_Load(object sender, EventArgs e)
    {
      this.grd.SelectedObject = Properties.Settings.Default;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.Save();
      this.Close();
    }
  }
}
