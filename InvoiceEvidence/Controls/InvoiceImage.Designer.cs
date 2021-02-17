namespace InvoiceEvidence.Controls
{
  partial class InvoiceImage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceImage));
      this.pic = new System.Windows.Forms.PictureBox();
      this.cmsPic = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.fillCurrentFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fillCurrentFieldAndSelectnextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.zoominToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomautoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlLeft = new System.Windows.Forms.Panel();
      this.btnOpenInExplorer = new System.Windows.Forms.Button();
      this.chkRecognizeOn = new System.Windows.Forms.CheckBox();
      this.btnZoomFit = new System.Windows.Forms.Button();
      this.btnZoomOut = new System.Windows.Forms.Button();
      this.btnZoomIn = new System.Windows.Forms.Button();
      this.pnlContent = new System.Windows.Forms.Panel();
      this.lblMessage = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
      this.cmsPic.SuspendLayout();
      this.pnlLeft.SuspendLayout();
      this.pnlContent.SuspendLayout();
      this.SuspendLayout();
      // 
      // pic
      // 
      this.pic.ContextMenuStrip = this.cmsPic;
      this.pic.Location = new System.Drawing.Point(3, 3);
      this.pic.Name = "pic";
      this.pic.Size = new System.Drawing.Size(600, 450);
      this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pic.TabIndex = 0;
      this.pic.TabStop = false;
      this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
      this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
      // 
      // cmsPic
      // 
      this.cmsPic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillCurrentFieldToolStripMenuItem,
            this.fillCurrentFieldAndSelectnextToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zoominToolStripMenuItem,
            this.zoomoutToolStripMenuItem,
            this.zoomresetToolStripMenuItem,
            this.zoomautoToolStripMenuItem});
      this.cmsPic.Name = "cmsPic";
      this.cmsPic.Size = new System.Drawing.Size(239, 142);
      // 
      // fillCurrentFieldToolStripMenuItem
      // 
      this.fillCurrentFieldToolStripMenuItem.Name = "fillCurrentFieldToolStripMenuItem";
      this.fillCurrentFieldToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.fillCurrentFieldToolStripMenuItem.Text = "&Fill current field";
      // 
      // fillCurrentFieldAndSelectnextToolStripMenuItem
      // 
      this.fillCurrentFieldAndSelectnextToolStripMenuItem.Name = "fillCurrentFieldAndSelectnextToolStripMenuItem";
      this.fillCurrentFieldAndSelectnextToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.fillCurrentFieldAndSelectnextToolStripMenuItem.Text = "Fill current field and select &next";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
      // 
      // zoominToolStripMenuItem
      // 
      this.zoominToolStripMenuItem.Name = "zoominToolStripMenuItem";
      this.zoominToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.zoominToolStripMenuItem.Text = "Zoom &in";
      this.zoominToolStripMenuItem.Click += new System.EventHandler(this.zoominToolStripMenuItem_Click);
      // 
      // zoomoutToolStripMenuItem
      // 
      this.zoomoutToolStripMenuItem.Name = "zoomoutToolStripMenuItem";
      this.zoomoutToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.zoomoutToolStripMenuItem.Text = "Zoom &out";
      this.zoomoutToolStripMenuItem.Click += new System.EventHandler(this.zoomoutToolStripMenuItem_Click);
      // 
      // zoomresetToolStripMenuItem
      // 
      this.zoomresetToolStripMenuItem.Name = "zoomresetToolStripMenuItem";
      this.zoomresetToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.zoomresetToolStripMenuItem.Text = "Zoom &reset";
      this.zoomresetToolStripMenuItem.Click += new System.EventHandler(this.zoomresetToolStripMenuItem_Click);
      // 
      // zoomautoToolStripMenuItem
      // 
      this.zoomautoToolStripMenuItem.Name = "zoomautoToolStripMenuItem";
      this.zoomautoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
      this.zoomautoToolStripMenuItem.Text = "Zoom &auto";
      // 
      // pnlLeft
      // 
      this.pnlLeft.Controls.Add(this.btnOpenInExplorer);
      this.pnlLeft.Controls.Add(this.chkRecognizeOn);
      this.pnlLeft.Controls.Add(this.btnZoomFit);
      this.pnlLeft.Controls.Add(this.btnZoomOut);
      this.pnlLeft.Controls.Add(this.btnZoomIn);
      this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlLeft.Location = new System.Drawing.Point(0, 0);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Size = new System.Drawing.Size(55, 482);
      this.pnlLeft.TabIndex = 1;
      // 
      // btnOpenInExplorer
      // 
      this.btnOpenInExplorer.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenInExplorer.Image")));
      this.btnOpenInExplorer.Location = new System.Drawing.Point(9, 202);
      this.btnOpenInExplorer.Name = "btnOpenInExplorer";
      this.btnOpenInExplorer.Size = new System.Drawing.Size(40, 40);
      this.btnOpenInExplorer.TabIndex = 5;
      this.btnOpenInExplorer.UseVisualStyleBackColor = true;
      this.btnOpenInExplorer.Click += new System.EventHandler(this.btnOpenInExplorer_Click);
      // 
      // chkRecognizeOn
      // 
      this.chkRecognizeOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkRecognizeOn.Image = ((System.Drawing.Image)(resources.GetObject("chkRecognizeOn.Image")));
      this.chkRecognizeOn.Location = new System.Drawing.Point(9, 149);
      this.chkRecognizeOn.Name = "chkRecognizeOn";
      this.chkRecognizeOn.Size = new System.Drawing.Size(40, 47);
      this.chkRecognizeOn.TabIndex = 4;
      this.chkRecognizeOn.UseVisualStyleBackColor = true;
      // 
      // btnZoomFit
      // 
      this.btnZoomFit.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomFit.Image")));
      this.btnZoomFit.Location = new System.Drawing.Point(9, 92);
      this.btnZoomFit.Name = "btnZoomFit";
      this.btnZoomFit.Size = new System.Drawing.Size(40, 40);
      this.btnZoomFit.TabIndex = 2;
      this.btnZoomFit.UseVisualStyleBackColor = true;
      this.btnZoomFit.Click += new System.EventHandler(this.btnZoomFit_Click);
      // 
      // btnZoomOut
      // 
      this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
      this.btnZoomOut.Location = new System.Drawing.Point(9, 50);
      this.btnZoomOut.Name = "btnZoomOut";
      this.btnZoomOut.Size = new System.Drawing.Size(40, 40);
      this.btnZoomOut.TabIndex = 1;
      this.btnZoomOut.UseVisualStyleBackColor = true;
      this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
      // 
      // btnZoomIn
      // 
      this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
      this.btnZoomIn.Location = new System.Drawing.Point(9, 8);
      this.btnZoomIn.Name = "btnZoomIn";
      this.btnZoomIn.Size = new System.Drawing.Size(40, 40);
      this.btnZoomIn.TabIndex = 0;
      this.btnZoomIn.UseVisualStyleBackColor = true;
      this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
      // 
      // pnlContent
      // 
      this.pnlContent.AutoScroll = true;
      this.pnlContent.Controls.Add(this.pic);
      this.pnlContent.Controls.Add(this.lblMessage);
      this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlContent.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.pnlContent.Location = new System.Drawing.Point(55, 0);
      this.pnlContent.Name = "pnlContent";
      this.pnlContent.Size = new System.Drawing.Size(711, 482);
      this.pnlContent.TabIndex = 2;
      // 
      // lblMessage
      // 
      this.lblMessage.AutoSize = true;
      this.lblMessage.Location = new System.Drawing.Point(6, 8);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(17, 17);
      this.lblMessage.TabIndex = 1;
      this.lblMessage.Text = "-";
      // 
      // InvoiceImage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.Controls.Add(this.pnlContent);
      this.Controls.Add(this.pnlLeft);
      this.Name = "InvoiceImage";
      this.Size = new System.Drawing.Size(766, 482);
      ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
      this.cmsPic.ResumeLayout(false);
      this.pnlLeft.ResumeLayout(false);
      this.pnlContent.ResumeLayout(false);
      this.pnlContent.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pic;
    private System.Windows.Forms.ContextMenuStrip cmsPic;
    private System.Windows.Forms.ToolStripMenuItem zoominToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomresetToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomautoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem fillCurrentFieldToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fillCurrentFieldAndSelectnextToolStripMenuItem;
    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Button btnZoomFit;
    private System.Windows.Forms.Button btnZoomOut;
    private System.Windows.Forms.Button btnZoomIn;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.CheckBox chkRecognizeOn;
    private System.Windows.Forms.Button btnOpenInExplorer;
    private System.Windows.Forms.Label lblMessage;
  }
}
