using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceEvidence
{
  public static class EIO
  {
    private static List<string> deleteOnExitList = new List<string>();

    public static string GetTempFileName(string extension)
    {
      string ret = null;
      do
      {
        ret = System.IO.Path.Combine(
          Program.AppSettings.TempDirectory, 
          System.IO.Path.GetRandomFileName() + "." + extension);
      } while (System.IO.File.Exists(ret));
      return ret;
    }

    public static void DoDeleteOnExit()
    {
      foreach (var file in deleteOnExitList)
      {
        try
        {
          System.IO.File.Delete(file);
        }catch(Exception)
        {
          // intentionally blank
        }
      }
    }

    internal static void DeleteOnExit(string outFile)
    {
      deleteOnExitList.Add(outFile);
    }
  }
}
