﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace InvoiceEvidence.OCR
{
  public class TesseractOCR : IOCR
  {
    private static readonly string TESSERACT_MASTER_DIR = Program.AppSettings.TesseractDirectory;
    private static string TEMPORAL_DIRECTORY { get; set; } = Program.AppSettings.TempDirectory;
    private static readonly string LANGUAGES = Program.AppSettings.TesseractLanguages;
    private static string GetTesseractMasterDirectory()
    {
      string ret = System.Reflection.Assembly.GetEntryAssembly().Location;
      ret = System.IO.Path.GetDirectoryName(ret);
      ret = System.IO.Path.Combine(ret, TESSERACT_MASTER_DIR);
      return ret;
    }

    public string ReadText(Image img)
    {
      string tempImageFileName = EIO.GetTempFileName("jpg");
      string tempTextFileName = tempImageFileName;
      img.Save(tempImageFileName);

      try
      {
        RunProcess(tempImageFileName, tempTextFileName);
      }
      catch (Exception ex)
      {
        throw new Exception("Failed to read text.", ex);
      }

      string ret = System.IO.File.ReadAllText(tempTextFileName + ".txt");

      TryDeleteFile(tempImageFileName);
      TryDeleteFile(tempTextFileName + ".txt");

      return ret;
    }

    private void TryDeleteFile(string fileName)
    {
      try
      {
        System.IO.File.Delete(fileName);
      }
      catch (Exception)
      {
        // intentionally blank
      }
    }

    private void RunProcess(string imageFileName, string textFileName)
    {
      string output = string.Empty;

      ProcessStartInfo psi = new ProcessStartInfo
      {
        WorkingDirectory = GetTesseractMasterDirectory(),
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true,
        UseShellExecute = false,
        FileName = "cmd.exe",
        Arguments =
            "/c tesseract.exe " +
            // Image file.
            imageFileName + " " +
            // Output file (tesseract add '.txt' at the end)
            textFileName +
            // Languages.
            " -l " + LANGUAGES
      };

      // Start tesseract.
      Process process = Process.Start(psi);
      process.WaitForExit();
      if (process.ExitCode != 0)
      {
        throw new Exception("Error. Tesseract stopped with an error code = " + process.ExitCode);
      }
    }
  }
}
