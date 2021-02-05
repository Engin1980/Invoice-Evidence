using InvoiceEvidence.OCR;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  public partial class InvoceImage : UserControl
  {
    public delegate void OnBlockTextRecognized(InvoceImage sender, string text);
    public event OnBlockTextRecognized BlockTextRecognized;

    private void Pic_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta < 0)
        ZoomIn();
      else
        ZoomOut();
    }

    class Zoom
    {
      private const double STEP = 0.1;
      private const double MIN = 0.1;
      public double Value { get; private set; } = 1;

      public void Reset()
      {
        Value = 1;
      }

      public void ZoomIn()
      {
        Value = Value + STEP;
      }

      public void ZoomOut()
      {
        Value = Value - STEP;
        if (Value < MIN)
          Value = MIN;
      }
    }

    private Image originalImage;
    private Image scalledImage;
    private Zoom zoom = new Zoom();
    private IOCR ocr = new TesseractOCR();

    public void ClearImageFile()
    {
      this.originalImage = null;
      this.scalledImage = null;
      this.zoom.Reset();
      this.pic.Image = null;
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

    public InvoceImage()
    {
      InitializeComponent();
      pic.MouseWheel += Pic_MouseWheel;
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
        DoImageRecognition(mouseDownPoint, mouseUpPoint);
      else
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
      throw new NotImplementedException();
    }
  }
}
