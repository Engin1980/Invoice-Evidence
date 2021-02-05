namespace InvoiceEvidence
{
  partial class InvoceRow
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoceRow));
      this.lblShop = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblNumber = new System.Windows.Forms.Label();
      this.btnView = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.invoceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.invoceBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // lblShop
      // 
      this.lblShop.AutoSize = true;
      this.lblShop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "ShopName", true));
      this.lblShop.Location = new System.Drawing.Point(24, 48);
      this.lblShop.Name = "lblShop";
      this.lblShop.Size = new System.Drawing.Size(44, 17);
      this.lblShop.TabIndex = 0;
      this.lblShop.Text = "Shop";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "Date", true));
      this.lblDate.Location = new System.Drawing.Point(24, 28);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(116, 17);
      this.lblDate.TabIndex = 4;
      this.lblDate.Text = "--. --. ----";
      // 
      // lblNumber
      // 
      this.lblNumber.AutoSize = true;
      this.lblNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "Number", true));
      this.lblNumber.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblNumber.Location = new System.Drawing.Point(12, 8);
      this.lblNumber.Name = "lblNumber";
      this.lblNumber.Size = new System.Drawing.Size(62, 17);
      this.lblNumber.TabIndex = 5;
      this.lblNumber.Text = "Number";
      // 
      // btnView
      // 
      this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
      this.btnView.Location = new System.Drawing.Point(856, 12);
      this.btnView.Name = "btnView";
      this.btnView.Size = new System.Drawing.Size(48, 48);
      this.btnView.TabIndex = 6;
      this.btnView.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "ItemsOverview", true));
      this.label1.Location = new System.Drawing.Point(247, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(603, 56);
      this.label1.TabIndex = 7;
      this.label1.Text = "-";
      // 
      // invoceBindingSource
      // 
      this.invoceBindingSource.DataSource = typeof(InvoceEvidenceLib.Invoce);
      // 
      // InvoceRow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnView);
      this.Controls.Add(this.lblNumber);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblShop);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InvoceRow";
      this.Size = new System.Drawing.Size(907, 73);
      ((System.ComponentModel.ISupportInitialize)(this.invoceBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblShop;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblNumber;
    private System.Windows.Forms.BindingSource invoceBindingSource;
    private System.Windows.Forms.Button btnView;
    private System.Windows.Forms.Label label1;
  }
}
