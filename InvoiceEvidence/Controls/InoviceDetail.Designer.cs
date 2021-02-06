namespace InvoiceEvidence.Controls
{
  partial class InoviceDetail
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlData = new System.Windows.Forms.Panel();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.txtOrderNumber = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.dtpDate = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
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
      this.pnlFill = new System.Windows.Forms.Panel();
      this.picInvoice = new InvoiceEvidence.InvoiceImage();
      this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.pnlFill.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlData
      // 
      this.pnlData.Controls.Add(this.splitContainer2);
      this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlData.Location = new System.Drawing.Point(0, 0);
      this.pnlData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pnlData.Name = "pnlData";
      this.pnlData.Size = new System.Drawing.Size(1129, 222);
      this.pnlData.TabIndex = 1;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.txtOrderNumber);
      this.splitContainer2.Panel1.Controls.Add(this.label8);
      this.splitContainer2.Panel1.Controls.Add(this.dtpDate);
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
      this.splitContainer2.Size = new System.Drawing.Size(1129, 222);
      this.splitContainer2.SplitterDistance = 376;
      this.splitContainer2.SplitterWidth = 6;
      this.splitContainer2.TabIndex = 0;
      // 
      // txtOrderNumber
      // 
      this.txtOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOrderNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OrderNumber", true));
      this.txtOrderNumber.Location = new System.Drawing.Point(164, 126);
      this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtOrderNumber.Name = "txtOrderNumber";
      this.txtOrderNumber.Size = new System.Drawing.Size(188, 23);
      this.txtOrderNumber.TabIndex = 23;
      this.txtOrderNumber.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(22, 129);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(98, 17);
      this.label8.TabIndex = 22;
      this.label8.Text = "Order No.:";
      // 
      // dtpDate
      // 
      this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dtpDate.CustomFormat = "d. MMMM yyyy";
      this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
      this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDate.Location = new System.Drawing.Point(164, 95);
      this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dtpDate.Name = "dtpDate";
      this.dtpDate.Size = new System.Drawing.Size(188, 23);
      this.dtpDate.TabIndex = 19;
      this.dtpDate.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(22, 191);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(78, 17);
      this.label6.TabIndex = 17;
      this.label6.Text = "Comment:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(22, 160);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 17);
      this.label5.TabIndex = 16;
      this.label5.Text = "Keywords:";
      // 
      // txtComment
      // 
      this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Comment", true));
      this.txtComment.Location = new System.Drawing.Point(164, 188);
      this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(188, 23);
      this.txtComment.TabIndex = 15;
      this.txtComment.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtKeywords
      // 
      this.txtKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKeywords.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Keywords", true));
      this.txtKeywords.Location = new System.Drawing.Point(164, 157);
      this.txtKeywords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtKeywords.Name = "txtKeywords";
      this.txtKeywords.Size = new System.Drawing.Size(188, 23);
      this.txtKeywords.TabIndex = 14;
      this.txtKeywords.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtNumber
      // 
      this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Number", true));
      this.txtNumber.Location = new System.Drawing.Point(164, 65);
      this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(188, 23);
      this.txtNumber.TabIndex = 12;
      this.txtNumber.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtShop
      // 
      this.txtShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtShop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ShopName", true));
      this.txtShop.Location = new System.Drawing.Point(164, 34);
      this.txtShop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtShop.Name = "txtShop";
      this.txtShop.Size = new System.Drawing.Size(188, 23);
      this.txtShop.TabIndex = 11;
      this.txtShop.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // txtFile
      // 
      this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FileName", true));
      this.txtFile.Location = new System.Drawing.Point(164, 4);
      this.txtFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtFile.Name = "txtFile";
      this.txtFile.ReadOnly = true;
      this.txtFile.Size = new System.Drawing.Size(188, 23);
      this.txtFile.TabIndex = 10;
      this.txtFile.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 7);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 17);
      this.label4.TabIndex = 9;
      this.label4.Text = "File:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 100);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 17);
      this.label3.TabIndex = 8;
      this.label3.Text = "Date:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 68);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Number:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 37);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Shop:";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.dataGridView1);
      this.groupBox1.Location = new System.Drawing.Point(4, 7);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(739, 211);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Invoice items:";
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
      this.dataGridView1.Location = new System.Drawing.Point(9, 24);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(722, 178);
      this.dataGridView1.TabIndex = 48;
      this.dataGridView1.Enter += new System.EventHandler(this.ctr_Enter);
      // 
      // pnlFill
      // 
      this.pnlFill.Controls.Add(this.picInvoice);
      this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlFill.Location = new System.Drawing.Point(0, 222);
      this.pnlFill.Name = "pnlFill";
      this.pnlFill.Size = new System.Drawing.Size(1129, 428);
      this.pnlFill.TabIndex = 2;
      // 
      // picInvoice
      // 
      this.picInvoice.AutoScroll = true;
      this.picInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picInvoice.Location = new System.Drawing.Point(0, 0);
      this.picInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.picInvoice.Name = "picInvoice";
      this.picInvoice.Size = new System.Drawing.Size(1129, 428);
      this.picInvoice.TabIndex = 0;
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
      dataGridViewCellStyle1.Format = "N2";
      this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
      this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
      // 
      // keywordsDataGridViewTextBoxColumn
      // 
      this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
      this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
      this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
      this.keywordsDataGridViewTextBoxColumn.Width = 500;
      // 
      // InoviceDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlFill);
      this.Controls.Add(this.pnlData);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "InoviceDetail";
      this.Size = new System.Drawing.Size(1129, 650);
      this.Load += new System.EventHandler(this.InoviceDetail_Load);
      this.pnlData.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.pnlFill.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlData;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.TextBox txtOrderNumber;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtKeywords;
    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.TextBox txtShop;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel pnlFill;
    private InvoiceImage picInvoice;
    private System.Windows.Forms.BindingSource invoiceBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource itemsBindingSource;
  }
}
