using System;
using System.Text;

namespace InvoiceEvidence
{
  public static class Extensions
  {
    public static System.Drawing.Size Multiply(this System.Drawing.Size origin, double value)
    {
      return new System.Drawing.Size((int)(origin.Width * value), (int)(origin.Height * value));
    }

    public static string GetJoinedMessages(this Exception ex, string delimiter = " => ")
    {
      Exception t = ex;
      StringBuilder sb = new StringBuilder();
      while (t != null)
      {
        if (t != ex)
          sb.Append(delimiter);
        sb.Append(t.Message);
        t = t.InnerException;
      }
      return sb.ToString();
    }
  }
}
