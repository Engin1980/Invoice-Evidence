namespace InvoiceEvidence
{
  partial class FrmNewInvoce
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
      this.picInvoce = new InvoiceEvidence.InvoceImage();
      this.pnlData = new System.Windows.Forms.Panel();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.dtpDate = new System.Windows.Forms.DateTimePicker();
      this.btnSave = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.invoceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.txtKeywords = new System.Windows.Forms.TextBox();
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.txtShop = new System.Windows.Forms.TextBox();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
      this.splMain.Panel1.SuspendLayout();
      this.splMain.Panel2.SuspendLayout();
      this.splMain.SuspendLayout();
      this.pnlImage.SuspendLayout();
      this.pnlData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.invoceBindingSource)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      this.splMain.Panel2.Controls.Add(this.pnlData);
      this.splMain.Size = new System.Drawing.Size(1200, 589);
      this.splMain.SplitterDistance = 179;
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
      this.lstFiles.Size = new System.Drawing.Size(179, 589);
      this.lstFiles.TabIndex = 0;
      this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
      // 
      // pnlImage
      // 
      this.pnlImage.AutoScroll = true;
      this.pnlImage.Controls.Add(this.picInvoce);
      this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlImage.Location = new System.Drawing.Point(0, 223);
      this.pnlImage.Name = "pnlImage";
      this.pnlImage.Size = new System.Drawing.Size(1017, 366);
      this.pnlImage.TabIndex = 1;
      // 
      // picInvoce
      // 
      this.picInvoce.AutoScroll = true;
      this.picInvoce.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picInvoce.Location = new System.Drawing.Point(0, 0);
      this.picInvoce.Margin = new System.Windows.Forms.Padding(4);
      this.picInvoce.Name = "picInvoce";
      this.picInvoce.Size = new System.Drawing.Size(1017, 366);
      this.picInvoce.TabIndex = 0;
      // 
      // pnlData
      // 
      this.pnlData.Controls.Add(this.splitContainer2);
      this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlData.Location = new System.Drawing.Point(0, 0);
      this.pnlData.Name = "pnlData";
      this.pnlData.Size = new System.Drawing.Size(1017, 223);
      this.pnlData.TabIndex = 0;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.dtpDate);
      this.splitContainer2.Panel1.Controls.Add(this.btnSave);
      this.splitContainer2.Panel1.Controls.Add(this.label6);
      this.splitContainer2.Panel1.Controls.Add(this.label5);
      this.splitContainer2.Panel1.Controls.Add(this.txtComment);
      this.splitContainer2.Panel1.Controls.Add(this.txtKeywords);
      this.splitContainer2.Panel1.Controls.Add(this.txtNumber);
      this.splitContainer2.Panel1.Controls.Add(this.txtShop);
      this.splitContainer2.Panel1.Controls.Add(this.txtFile);
      this.splitContainer2.Panel1.Controls.Add(this.label4);
      this.splitContainer2.Panel1.Controls.Add(this.label3);
      this.splitContainer2.Panel1.Controls.Add(this.label2);
      this.splitContainer2.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
      this.splitContainer2.Size = new System.Drawing.Size(1017, 223);
      this.splitContainer2.SplitterDistance = 339;
      this.splitContainer2.TabIndex = 0;
      // 
      // dtpDate
      // 
      this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dtpDate.CustomFormat = "d. MMMM yyyy";
      this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoceBindingSource, "Date", true));
      this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDate.Location = new System.Drawing.Point(109, 99);
      this.dtpDate.Name = "dtpDate";
      this.dtpDate.Size = new System.Drawing.Size(215, 23);
      this.dtpDate.TabIndex = 19;
      this.dtpDate.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Location = new System.Drawing.Point(109, 186);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(215, 26);
      this.btnSave.TabIndex = 18;
      this.btnSave.Text = "Save invoce to system";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(15, 160);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(78, 17);
      this.label6.TabIndex = 17;
      this.label6.Text = "Comment:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 131);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 17);
      this.label5.TabIndex = 16;
      this.label5.Text = "Keywords:";
      // 
      // txtComment
      // 
      this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "Comment", true));
      this.txtComment.Location = new System.Drawing.Point(109, 157);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(215, 23);
      this.txtComment.TabIndex = 15;
      this.txtComment.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // invoceBindingSource
      // 
      this.invoceBindingSource.DataSource = typeof(InvoceEvidenceLib.Invoce);
      // 
      // txtKeywords
      // 
      this.txtKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKeywords.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "Keywords", true));
      this.txtKeywords.Location = new System.Drawing.Point(109, 128);
      this.txtKeywords.Name = "txtKeywords";
      this.txtKeywords.Size = new System.Drawing.Size(215, 23);
      this.txtKeywords.TabIndex = 14;
      this.txtKeywords.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtNumber
      // 
      this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "Number", true));
      this.txtNumber.Location = new System.Drawing.Point(109, 70);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(215, 23);
      this.txtNumber.TabIndex = 12;
      this.txtNumber.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtShop
      // 
      this.txtShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtShop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "ShopName", true));
      this.txtShop.Location = new System.Drawing.Point(109, 41);
      this.txtShop.Name = "txtShop";
      this.txtShop.Size = new System.Drawing.Size(215, 23);
      this.txtShop.TabIndex = 11;
      this.txtShop.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtFile
      // 
      this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoceBindingSource, "FileName", true));
      this.txtFile.Location = new System.Drawing.Point(109, 12);
      this.txtFile.Name = "txtFile";
      this.txtFile.ReadOnly = true;
      this.txtFile.Size = new System.Drawing.Size(215, 23);
      this.txtFile.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 15);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 17);
      this.label4.TabIndex = 9;
      this.label4.Text = "File:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 102);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 17);
      this.label3.TabIndex = 8;
      this.label3.Text = "Date:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Number:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Shop:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dataGridView1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(674, 223);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Invoce items (unused leave empty):";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labelDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.itemsBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(6, 26);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(656, 190);
      this.dataGridView1.TabIndex = 48;
      this.dataGridView1.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // labelDataGridViewTextBoxColumn
      // 
      this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
      this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
      this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
      this.labelDataGridViewTextBoxColumn.Width = 250;
      // 
      // amountDataGridViewTextBoxColumn
      // 
      this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
      this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
      this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
      // 
      // keywordsDataGridViewTextBoxColumn
      // 
      this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
      this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
      this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
      // 
      // itemsBindingSource
      // 
      this.itemsBindingSource.DataMember = "Items";
      this.itemsBindingSource.DataSource = this.invoceBindingSource;
      // 
      // FrmNewInvoce
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 589);
      this.Controls.Add(this.splMain);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmNewInvoce";
      this.Text = "FrmNewInvoce";
      this.Load += new System.EventHandler(this.FrmNewInvoce_Load);
      this.splMain.Panel1.ResumeLayout(false);
      this.splMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
      this.splMain.ResumeLayout(false);
      this.pnlImage.ResumeLayout(false);
      this.pnlData.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.invoceBindingSource)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splMain;
    private System.Windows.Forms.ListBox lstFiles;
    private System.Windows.Forms.Panel pnlData;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.TextBox txtKeywords;
    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.TextBox txtShop;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource invoceBindingSource;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Panel pnlImage;
    private InvoceImage picInvoce;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource itemsBindingSource;
  }
}