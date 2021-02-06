namespace InvoiceEvidence.Forms
{
  partial class FrmDetail
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.invoiceDetail = new InvoiceEvidence.Controls.InvoiceDetail();
      this.SuspendLayout();
      // 
      // invoiceDetail
      // 
      this.invoiceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.invoiceDetail.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.invoiceDetail.Invoice = null;
      this.invoiceDetail.Location = new System.Drawing.Point(0, 0);
      this.invoiceDetail.Margin = new System.Windows.Forms.Padding(4);
      this.invoiceDetail.Name = "invoiceDetail";
      this.invoiceDetail.RecognitionEnabled = false;
      this.invoiceDetail.Size = new System.Drawing.Size(800, 450);
      this.invoiceDetail.TabIndex = 0;
      // 
      // FrmDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.invoiceDetail);
      this.Name = "FrmDetail";
      this.Text = "FrmDetail";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDetail_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.InvoiceDetail invoiceDetail;
  }
}