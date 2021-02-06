namespace InvoiceEvidence
{
  partial class FrmNewInvoice
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
      this.components = new System.ComponentModel.Container();
      this.splMain = new System.Windows.Forms.SplitContainer();
      this.lstFiles = new System.Windows.Forms.ListBox();
      this.pnlImage = new System.Windows.Forms.Panel();
      this.pnlFill = new System.Windows.Forms.Panel();
      this.invoceDetail = new InvoiceEvidence.Controls.InvoiceDetail();
      this.pnlBottom = new System.Windows.Forms.Panel();
      this.btnSave = new System.Windows.Forms.Button();
      this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
      this.splMain.Panel1.SuspendLayout();
      this.splMain.Panel2.SuspendLayout();
      this.splMain.SuspendLayout();
      this.pnlImage.SuspendLayout();
      this.pnlFill.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // splMain
      // 
      this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splMain.Location = new System.Drawing.Point(0, 0);
      this.splMain.Name = "splMain";
      // 
      // splMain.Panel1
      // 
      this.splMain.Panel1.Controls.Add(this.lstFiles);
      // 
      // splMain.Panel2
      // 
      this.splMain.Panel2.Controls.Add(this.pnlImage);
      this.splMain.Size = new System.Drawing.Size(1184, 474);
      this.splMain.SplitterDistance = 176;
      this.splMain.TabIndex = 0;
      // 
      // lstFiles
      // 
      this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstFiles.FormattingEnabled = true;
      this.lstFiles.IntegralHeight = false;
      this.lstFiles.ItemHeight = 17;
      this.lstFiles.Location = new System.Drawing.Point(0, 0);
      this.lstFiles.Name = "lstFiles";
      this.lstFiles.Size = new System.Drawing.Size(176, 474);
      this.lstFiles.TabIndex = 0;
      this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
      // 
      // pnlImage
      // 
      this.pnlImage.AutoScroll = true;
      this.pnlImage.Controls.Add(this.pnlFill);
      this.pnlImage.Controls.Add(this.pnlBottom);
      this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlImage.Location = new System.Drawing.Point(0, 0);
      this.pnlImage.Name = "pnlImage";
      this.pnlImage.Size = new System.Drawing.Size(1004, 474);
      this.pnlImage.TabIndex = 1;
      // 
      // pnlFill
      // 
      this.pnlFill.Controls.Add(this.invoceDetail);
      this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlFill.Location = new System.Drawing.Point(0, 0);
      this.pnlFill.Name = "pnlFill";
      this.pnlFill.Size = new System.Drawing.Size(1004, 414);
      this.pnlFill.TabIndex = 1;
      // 
      // invoceDetail
      // 
      this.invoceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.invoceDetail.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.invoceDetail.Invoice = null;
      this.invoceDetail.Location = new System.Drawing.Point(0, 0);
      this.invoceDetail.Margin = new System.Windows.Forms.Padding(4);
      this.invoceDetail.Name = "invoceDetail";
      this.invoceDetail.Size = new System.Drawing.Size(1004, 414);
      this.invoceDetail.TabIndex = 0;
      // 
      // pnlBottom
      // 
      this.pnlBottom.Controls.Add(this.btnSave);
      this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlBottom.Location = new System.Drawing.Point(0, 414);
      this.pnlBottom.Name = "pnlBottom";
      this.pnlBottom.Size = new System.Drawing.Size(1004, 60);
      this.pnlBottom.TabIndex = 0;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Location = new System.Drawing.Point(13, 7);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(979, 41);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Confirm changes and add this invoice into the database";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // invoiceBindingSource
      // 
      this.invoiceBindingSource.DataSource = typeof(InvoiceEvidenceLib.Invoice);
      // 
      // itemsBindingSource
      // 
      this.itemsBindingSource.DataMember = "Items";
      this.itemsBindingSource.DataSource = this.invoiceBindingSource;
      // 
      // FrmNewInvoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1184, 474);
      this.Controls.Add(this.splMain);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmNewInvoice";
      this.Text = "FrmNewInvoice";
      this.Load += new System.EventHandler(this.FrmNewInvoice_Load);
      this.splMain.Panel1.ResumeLayout(false);
      this.splMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
      this.splMain.ResumeLayout(false);
      this.pnlImage.ResumeLayout(false);
      this.pnlFill.ResumeLayout(false);
      this.pnlBottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splMain;
    private System.Windows.Forms.ListBox lstFiles;
    private System.Windows.Forms.BindingSource invoiceBindingSource;
    private System.Windows.Forms.Panel pnlImage;
    private System.Windows.Forms.BindingSource itemsBindingSource;
    private System.Windows.Forms.Panel pnlFill;
    private Controls.InvoiceDetail invoceDetail;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.Button btnSave;
  }
}