﻿using InvoiceEvidence.OCR;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceEvidence.Controls
{
  public partial class InvoiceImage : UserControl
  {
    private class Zoom
    {
      private const double MAX = 10;
      private const double MIN = 0.1;
      private const double STEP = 0.1;
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

    public delegate void OnBlockTextRecognized(InvoiceImage sender, string text);

    public event OnBlockTextRecognized BlockTextRecognized;

    private Point mouseDownPoint;

    private IOCR ocr = new TesseractOCR();

    private Zoom zoom = new Zoom();

    public bool RecognitionEnabled
    {
      get => chkRecognizeOn.Checked;
      set => chkRecognizeOn.Checked = value;
    }

    private Image _OriginalImage;
    private Image OriginalImage
    {
      get => _OriginalImage;
      set
      {
        if (_OriginalImage != null)
          _OriginalImage.Dispose();
        _OriginalImage = value;
      }
    }

    private string OriginalImageFileName { get; set; }

    private Image _ScalledImage;
    private Image ScalledImage
    {
      get => _ScalledImage; set
      {
        if (_ScalledImage != null)
          _ScalledImage.Dispose();
        _ScalledImage = value;
      }
    }

    public InvoiceImage()
    {
      InitializeComponent();
    }
    public void ClearImageFile()
    {
      OriginalImageFileName = null;
      OriginalImage = null;
      ScalledImage = null;
      zoom.Reset();
      pic.Image = null;
    }

    public void SetImageFile(string fileName, out bool isSuccess)
    {
      OriginalImageFileName = fileName;
      Image img;
      if (fileName.ToLower().EndsWith(".pdf"))
        try
        {
          img = LoadPdf(fileName);
        }
        catch (Exception ex)
        {
          lblMessage.Text = "PDF-as-image view is not available. " + ex.GetJoinedMessages();
          pic.Visible = false;
          isSuccess = false;
          return;
        }
      else
        try
        {
          img = LoadImage(fileName);
        }
        catch (Exception ex)
        {
          lblMessage.Text = "Image preview is not available. " + ex.GetJoinedMessages();
          pic.Visible = false;
          isSuccess = false;
          return;
        }


      OriginalImage = img;
      RefreshImage();
      pic.Visible = true;
      isSuccess = true;
    }

    public void ZoomFit()
    {
      int imgWidth = OriginalImage.Width;
      int cmpWidth = pnlContent.Width;
      double zoom = cmpWidth / (double)imgWidth;
      this.zoom.Set(zoom);
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

    public void ZoomReset()
    {
      zoom.Reset();
      RefreshImage();
    }

    private void btnOpenInExplorer_Click(object sender, EventArgs e)
    {
      ProcessStartInfo psi = new ProcessStartInfo()
      {
        FileName = "explorer.exe",
        Arguments = $" /select,\"{OriginalImageFileName}\""
      };

      Process p = new Process()
      {
        StartInfo = psi
      };

      p.Start();
    }

    private void btnZoomFit_Click(object sender, EventArgs e)
    {
      ZoomFit();
    }

    private void btnZoomIn_Click(object sender, EventArgs e)
    {
      ZoomIn();
    }

    private void btnZoomOut_Click(object sender, EventArgs e)
    {
      ZoomOut();
    }

    private void DoImageMove(Point mouseDownPoint, Point mouseUpPoint)
    {
      int widthChange = -(mouseUpPoint.X - mouseDownPoint.X);
      int heightChange = -(mouseUpPoint.Y - mouseDownPoint.Y);
      pnlContent.VerticalScroll.Value = EnsureBetween(
        pnlContent.VerticalScroll.Minimum,
        pnlContent.VerticalScroll.Value + heightChange,
        pnlContent.VerticalScroll.Maximum);
      pnlContent.HorizontalScroll.Value = EnsureBetween(
        pnlContent.HorizontalScroll.Minimum,
        pnlContent.HorizontalScroll.Value + widthChange,
        pnlContent.HorizontalScroll.Maximum);
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

      string s;
      using (Bitmap image = new Bitmap(OriginalImage))
      {
        using (Bitmap subimage = image.Clone(r, image.PixelFormat))
        {
          s = ocr.ReadText(subimage);
        }
      }

      BlockTextRecognized?.Invoke(this, s);
    }

    private int EnsureBetween(int minimum, int value, int maximum)
    {
      return Math.Max(minimum, Math.Min(value, maximum));
    }

    private Image LoadImage(string fileName)
    {
      Image ret;
      try
      {
        ret = Image.FromFile(fileName);
      }
      catch (Exception ex)
      {
        throw new ApplicationException($"Failed to load image file '{fileName}'.", ex);
      }
      return ret;
    }

    private Image LoadPdf(string fileName)
    {
      Image ret;
      try {
        ret = PdfToImageExtractor.ExtractImage(fileName);
      } catch(Exception ex)
      {
        throw new ApplicationException($"Failed to load pdf preview of '{fileName}.", ex);
      }
      
      return ret;
    }

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

    private void RefreshImage()
    {
      if (zoom.Value != 1)
        ScalledImage = new Bitmap(
          OriginalImage,
          OriginalImage.Size.Multiply(zoom.Value));
      else
        ScalledImage = new Bitmap(OriginalImage);

      pic.Image = ScalledImage;
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
  }
}