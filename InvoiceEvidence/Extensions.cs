using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceEvidence
{
  public static class Extensions
  {
    public static System.Drawing.Size Multiply(this System.Drawing.Size origin, double value)
    {
      return new System.Drawing.Size((int)(origin.Width * value), (int)(origin.Height * value));
    }
  }
}
