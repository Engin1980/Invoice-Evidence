namespace InvoiceEvidence.Forms
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAbout = new System.Windows.Forms.Button();
      this.btnSettings = new System.Windows.Forms.Button();
      this.chkColorize = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtQuickFilter = new System.Windows.Forms.TextBox();
      this.cmbOrderBy = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnReload = new System.Windows.Forms.Button();
      this.btnChangeFolder = new System.Windows.Forms.Button();
      this.btnAnalyseNewFiles = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.pnlFill = new System.Windows.Forms.Panel();
      this.grdItems = new System.Windows.Forms.DataGridView();
      this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.itemsOverviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pnlItems = new InvoiceEvidence.Controls.VerticalFlowPanel();
      this.panel1.SuspendLayout();
      this.pnlFill.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnAbout);
      this.panel1.Controls.Add(this.btnSettings);
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
      // btnAbout
      // 
      this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
      this.btnAbout.Location = new System.Drawing.Point(370, 12);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(48, 48);
      this.btnAbout.TabIndex = 10;
      this.btnAbout.UseVisualStyleBackColor = true;
      this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
      // 
      // btnSettings
      // 
      this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
      this.btnSettings.Location = new System.Drawing.Point(316, 12);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(48, 48);
      this.btnSettings.TabIndex = 9;
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // chkColorize
      // 
      this.chkColorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkColorize.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkColorize.Checked = true;
      this.chkColorize.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkColorize.Image = ((System.Drawing.Image)(resources.GetObject("chkColorize.Image")));
      this.chkColorize.Location = new System.Drawing.Point(705, 12);
      this.chkColorize.Name = "chkColorize";
      this.chkColorize.Size = new System.Drawing.Size(48, 48);
      this.chkColorize.TabIndex = 8;
      this.chkColorize.UseVisualStyleBackColor = true;
      this.chkColorize.CheckedChanged += new System.EventHandler(this.chkColorize_CheckedChanged);
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
      this.txtQuickFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuickFilter_KeyUp);
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
      // pnlFill
      // 
      this.pnlFill.Controls.Add(this.grdItems);
      this.pnlFill.Controls.Add(this.pnlItems);
      this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlFill.Location = new System.Drawing.Point(0, 71);
      this.pnlFill.Name = "pnlFill";
      this.pnlFill.Size = new System.Drawing.Size(1109, 510);
      this.pnlFill.TabIndex = 3;
      // 
      // grdItems
      // 
      this.grdItems.AllowUserToAddRows = false;
      this.grdItems.AllowUserToDeleteRows = false;
      this.grdItems.AutoGenerateColumns = false;
      this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.shopNameDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.itemsOverviewDataGridViewTextBoxColumn});
      this.grdItems.DataSource = this.invoiceBindingSource;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.grdItems.DefaultCellStyle = dataGridViewCellStyle2;
      this.grdItems.Location = new System.Drawing.Point(254, 22);
      this.grdItems.Name = "grdItems";
      this.grdItems.ReadOnly = true;
      this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdItems.Size = new System.Drawing.Size(828, 428);
      this.grdItems.TabIndex = 3;
      this.grdItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellDoubleClick);
      this.grdItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdItems_DataBindingComplete);
      // 
      // dateDataGridViewTextBoxColumn
      // 
      this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
      this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
      this.dateDataGridViewTextBoxColumn.ReadOnly = true;
      this.dateDataGridViewTextBoxColumn.Width = 75;
      // 
      // numberDataGridViewTextBoxColumn
      // 
      this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
      this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
      this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
      this.numberDataGridViewTextBoxColumn.ReadOnly = true;
      this.numberDataGridViewTextBoxColumn.Width = 92;
      // 
      // shopNameDataGridViewTextBoxColumn
      // 
      this.shopNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
      this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
      this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
      this.shopNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.shopNameDataGridViewTextBoxColumn.Width = 110;
      // 
      // orderNumberDataGridViewTextBoxColumn
      // 
      this.orderNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
      this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
      this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
      this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
      this.orderNumberDataGridViewTextBoxColumn.Width = 137;
      // 
      // totalPriceDataGridViewTextBoxColumn
      // 
      this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "N2";
      this.totalPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
      this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
      this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
      this.totalPriceDataGridViewTextBoxColumn.Width = 128;
      // 
      // itemsOverviewDataGridViewTextBoxColumn
      // 
      this.itemsOverviewDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.itemsOverviewDataGridViewTextBoxColumn.DataPropertyName = "ItemsOverview";
      this.itemsOverviewDataGridViewTextBoxColumn.HeaderText = "ItemsOverview";
      this.itemsOverviewDataGridViewTextBoxColumn.Name = "itemsOverviewDataGridViewTextBoxColumn";
      this.itemsOverviewDataGridViewTextBoxColumn.ReadOnly = true;
      this.itemsOverviewDataGridViewTextBoxColumn.Width = 155;
      // 
      // invoiceBindingSource
      // 
      this.invoiceBindingSource.DataSource = typeof(InvoiceEvidenceLib.Invoice);
      // 
      // pnlItems
      // 
      this.pnlItems.AutoScroll = true;
      this.pnlItems.AutoSize = true;
      this.pnlItems.Location = new System.Drawing.Point(48, 22);
      this.pnlItems.Name = "pnlItems";
      this.pnlItems.Size = new System.Drawing.Size(174, 428);
      this.pnlItems.TabIndex = 2;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1109, 581);
      this.Controls.Add(this.pnlFill);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Invoice Evidence";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.pnlFill.ResumeLayout(false);
      this.pnlFill.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
      this.ResumeLayout(false);

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
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.Panel pnlFill;
    private System.Windows.Forms.DataGridView grdItems;
    private System.Windows.Forms.BindingSource invoiceBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemsOverviewDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnAbout;
  }
}

