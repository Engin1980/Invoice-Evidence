using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceEvidence
{
  public class PdfToImageExtractor
  {
    internal static Image ExtractImage(string fileName)
    {
      string inFile = fileName;
      string outFile = EIO.GetTempFileName(".jpg");
      string gsFileName;
      if (string.IsNullOrEmpty(Program.AppSettings.GhostscriptLocation))
        gsFileName = "gswin64c.exe";
      else
        gsFileName = System.IO.Path.Combine(Program.AppSettings.GhostscriptLocation, "gswin64c.exe");

      ProcessStartInfo psi = new ProcessStartInfo()
      {
        Arguments = $" -sDEVICE=jpeg -r150 -o \"{outFile}\" \"{inFile}\"",
        CreateNoWindow=true,
        FileName = gsFileName,
        UseShellExecute=false,
        WindowStyle = ProcessWindowStyle.Hidden
      };

      Process p = new Process();
      p.StartInfo = psi;

      p.Start();
      p.WaitForExit();

      Image ret = Image.FromFile(outFile);
      EIO.DeleteOnExit(outFile);
      return ret;
    }
  }
}
