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
      this.btnReload = new System.Windows.Forms.Button();
      this.btnChangeFolder = new System.Windows.Forms.Button();
      this.btnAnalyseNewFiles = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
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
      this.Text = "Invoce Evidence";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnAnalyseNewFiles;
    private System.Windows.Forms.Button btnChangeFolder;
    private System.Windows.Forms.Button btnReload;
    private System.Windows.Forms.FlowLayoutPanel pnlItems;
  }
}

