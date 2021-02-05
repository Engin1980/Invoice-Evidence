namespace InvoiceEvidence
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
      this.pic = new System.Windows.Forms.PictureBox();
      this.cmsPic = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.fillCurrentFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fillCurrentFieldAndSelectnextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.zoominToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomautoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
      this.cmsPic.SuspendLayout();
      this.SuspendLayout();
      // 
      // pic
      // 
      this.pic.ContextMenuStrip = this.cmsPic;
      this.pic.Location = new System.Drawing.Point(0, 0);
      this.pic.Name = "pic";
      this.pic.Size = new System.Drawing.Size(732, 450);
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
      // InvoiceImage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.Controls.Add(this.pic);
      this.Name = "InvoiceImage";
      this.Size = new System.Drawing.Size(766, 482);
      ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
      this.cmsPic.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

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
  }
}
