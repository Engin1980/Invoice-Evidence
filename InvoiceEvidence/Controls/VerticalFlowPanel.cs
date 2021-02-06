using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceEvidence.Controls
{
  public class VerticalFlowPanel : FlowLayoutPanel
  {
    protected override CreateParams CreateParams
    {
      get
      {
        var cp = base.CreateParams;
        cp.Style |= 0x00200000; // WS_VSCROLL
        return cp;
      }
    }
  }
}
