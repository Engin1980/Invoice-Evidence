using InvoiceEvidence.OCR;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceEvidence.Controls
{
  public partial class InvoiceImage : UserControl
  {
    public delegate void OnBlockTextRecognized(InvoiceImage sender, string text);

    public event OnBlockTextRecognized BlockTextRecognized;

    public bool RecognitionEnabled
    {
      get => this.chkRecognizeOn.Checked;
      set => this.chkRecognizeOn.Checked = value;
    }

    private class Zoom
    {
      private const double STEP = 0.1;
      private const double MIN = 0.1;
      private const double MAX = 10;
      public double Value { get; private set; } = 1;

      public void Reset()
      {
        Set(1);
      }

      public void Set(double value)
      {
        Value = Math.Max(MIN, Math.Min(MAX, value));
      }

      public void ZoomIn()
      {
        Set(Value + STEP);
      }

      public void ZoomOut()
      {
        Set(Value - STEP);
      }
    }

    private Image originalImage;
    private Image scalledImage;
    private Zoom zoom = new Zoom();
    private IOCR ocr = new TesseractOCR();

    public void ClearImageFile()
    {
      originalImage = null;
      scalledImage = null;
      zoom.Reset();
      pic.Image = null;
    }

    public void SetImageFile(string fileName)
    {
      originalImage = Image.FromFile(fileName);
      RefreshImage();
    }

    public void ZoomReset()
    {
      zoom.Reset();
      RefreshImage();
    }

    public void ZoomIn()
    {
      zoom.ZoomIn();
      RefreshImage();
    }

    public void ZoomOut()
    {
      zoom.ZoomOut();
      RefreshImage();
    }

    public void ZoomFit()
    {
      int imgWidth = originalImage.Width;
      int cmpWidth = pnlContent.Width;
      double zoom = cmpWidth / (double)imgWidth;
      this.zoom.Set(zoom);
      RefreshImage();
    }

    private void RefreshImage()
    {
      if (zoom.Value != 1)
        scalledImage = new System.Drawing.Bitmap(
          originalImage,
          originalImage.Size.Multiply(zoom.Value));
      else
        scalledImage = originalImage;

      pic.Image = scalledImage;
    }

    public InvoiceImage()
    {
      InitializeComponent();
    }

    private void zoominToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      ZoomIn();
    }

    private void zoomoutToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      ZoomOut();
    }

    private void zoomresetToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      ZoomReset();
    }

    private Point mouseDownPoint;

    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      mouseDownPoint = e.Location;
    }

    private void pic_MouseUp(object sender, MouseEventArgs e)
    {
      Point mouseUpPoint = e.Location;

      if (e.Button == MouseButtons.Left)
      {
        if (chkRecognizeOn.Checked)
          DoImageRecognition(mouseDownPoint, mouseUpPoint);
      }
      else if (e.Button == MouseButtons.Middle)
        DoImageMove(mouseDownPoint, mouseUpPoint);
    }

    private void DoImageRecognition(Point mouseDownPoint, Point mouseUpPoint)
    {
      double x = mouseDownPoint.X;
      double y = mouseDownPoint.Y;
      double width = mouseUpPoint.X - mouseDownPoint.X;
      double height = mouseUpPoint.Y - mouseDownPoint.Y;

      x = x / zoom.Value;
      y = y / zoom.Value;
      width = width / zoom.Value;
      height = height / zoom.Value;

      Rectangle r = new Rectangle((int)x, (int)y, (int)width, (int)height);

      Bitmap image = new Bitmap(originalImage);
      image = image.Clone(r, image.PixelFormat);

      string s = ocr.ReadText(image);

      BlockTextRecognized?.Invoke(this, s);
    }

    private void DoImageMove(Point mouseDownPoint, Point mouseUpPoint)
    {
      int widthChange = - (mouseUpPoint.X - mouseDownPoint.X);
      int heightChange = - (mouseUpPoint.Y - mouseDownPoint.Y);
      pnlContent.VerticalScroll.Value = EnsureBetween(
        pnlContent.VerticalScroll.Minimum,
        pnlContent.VerticalScroll.Value + heightChange,
        pnlContent.VerticalScroll.Maximum);
      pnlContent.HorizontalScroll.Value = EnsureBetween(
        pnlContent.HorizontalScroll.Minimum,
        pnlContent.HorizontalScroll.Value + widthChange,
        pnlContent.HorizontalScroll.Maximum);

    }

    private int EnsureBetween(int minimum, int value, int maximum)
    {
      return Math.Max(minimum, Math.Min(value, maximum));
    }

    private void btnZoomIn_Click(object sender, EventArgs e)
    {
      ZoomIn();
    }

    private void btnZoomOut_Click(object sender, EventArgs e)
    {
      ZoomOut();
    }

    private void btnZoomFit_Click(object sender, EventArgs e)
    {
      ZoomFit();
    }
  }
}