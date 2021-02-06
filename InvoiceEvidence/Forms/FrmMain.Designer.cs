namespace InvoiceEvidence
{
  partial class FrmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.txtQuickFilter = new System.Windows.Forms.TextBox();
      this.cmbOrderBy = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnReload = new System.Windows.Forms.Button();
      this.btnChangeFolder = new System.Windows.Forms.Button();
      this.btnAnalyseNewFiles = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.pnlItems = new InvoiceEvidence.Controls.VerticalFlowPanel();
      this.chkColorize = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chkColorize);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtQuickFilter);
      this.panel1.Controls.Add(this.cmbOrderBy);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnReload);
      this.panel1.Controls.Add(this.btnChangeFolder);
      this.panel1.Controls.Add(this.btnAnalyseNewFiles);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1109, 71);
      this.panel1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(759, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(152, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Quick filter by:";
      // 
      // txtQuickFilter
      // 
      this.txtQuickFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtQuickFilter.Location = new System.Drawing.Point(917, 37);
      this.txtQuickFilter.Name = "txtQuickFilter";
      this.txtQuickFilter.Size = new System.Drawing.Size(180, 23);
      this.txtQuickFilter.TabIndex = 6;
      this.txtQuickFilter.TextChanged += new System.EventHandler(this.txtQuickFilter_TextChanged);
      // 
      // cmbOrderBy
      // 
      this.cmbOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOrderBy.FormattingEnabled = true;
      this.cmbOrderBy.Items.AddRange(new object[] {
            "Date",
            "Number",
            "Shop",
            "Total price desc",
            "Total price asc"});
      this.cmbOrderBy.Location = new System.Drawing.Point(917, 7);
      this.cmbOrderBy.Name = "cmbOrderBy";
      this.cmbOrderBy.Size = new System.Drawing.Size(180, 25);
      this.cmbOrderBy.TabIndex = 5;
      this.cmbOrderBy.SelectedIndexChanged += new System.EventHandler(this.cmbOrderBy_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(822, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 17);
      this.label1.TabIndex = 4;
      this.label1.Text = "Order by:";
      // 
      // btnReload
      // 
      this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
      this.btnReload.Location = new System.Drawing.Point(200, 12);
      this.btnReload.Name = "btnReload";
      this.btnReload.Size = new System.Drawing.Size(48, 48);
      this.btnReload.TabIndex = 3;
      this.btnReload.UseVisualStyleBackColor = true;
      this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
      // 
      // btnChangeFolder
      // 
      this.btnChangeFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeFolder.Image")));
      this.btnChangeFolder.Location = new System.Drawing.Point(12, 12);
      this.btnChangeFolder.Name = "btnChangeFolder";
      this.btnChangeFolder.Size = new System.Drawing.Size(48, 48);
      this.btnChangeFolder.TabIndex = 2;
      this.btnChangeFolder.UseVisualStyleBackColor = true;
      this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
      // 
      // btnAnalyseNewFiles
      // 
      this.btnAnalyseNewFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalyseNewFiles.Image")));
      this.btnAnalyseNewFiles.Location = new System.Drawing.Point(92, 12);
      this.btnAnalyseNewFiles.Name = "btnAnalyseNewFiles";
      this.btnAnalyseNewFiles.Size = new System.Drawing.Size(48, 48);
      this.btnAnalyseNewFiles.TabIndex = 1;
      this.btnAnalyseNewFiles.UseVisualStyleBackColor = true;
      this.btnAnalyseNewFiles.Click += new System.EventHandler(this.btnAnalyseNewFiles_Click);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Location = new System.Drawing.Point(146, 12);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(48, 48);
      this.btnSave.TabIndex = 0;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // pnlItems
      // 
      this.pnlItems.AutoScroll = true;
      this.pnlItems.AutoSize = true;
      this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlItems.Location = new System.Drawing.Point(0, 71);
      this.pnlItems.Name = "pnlItems";
      this.pnlItems.Size = new System.Drawing.Size(1109, 510);
      this.pnlItems.TabIndex = 2;
      // 
      // chkColorize
      // 
      this.chkColorize.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.chkColorize.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkColorize.Image = ((System.Drawing.Image)(resources.GetObject("chkColorize.Image")));
      this.chkColorize.Location = new System.Drawing.Point(705, 12);
      this.chkColorize.Name = "chkColorize";
      this.chkColorize.Size = new System.Drawing.Size(48, 48);
      this.chkColorize.TabIndex = 8;
      this.chkColorize.UseVisualStyleBackColor = true;
      this.chkColorize.CheckedChanged += new System.EventHandler(this.chkColorize_CheckedChanged);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1109, 581);
      this.Controls.Add(this.pnlItems);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Invoice Evidence";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnAnalyseNewFiles;
    private System.Windows.Forms.Button btnChangeFolder;
    private System.Windows.Forms.Button btnReload;
    private Controls.VerticalFlowPanel pnlItems;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtQuickFilter;
    private System.Windows.Forms.ComboBox cmbOrderBy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkColorize;
  }
}

