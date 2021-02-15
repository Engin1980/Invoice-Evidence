using InvoiceEvidenceLib;
using System.Collections.Generic;

namespace InvoiceEvidence
{
  public class Db
  {
    private List<Invoice> _Invoices = new List<Invoice>();
    public List<Invoice> Invoices
    {
      get => _Invoices;
      set => _Invoices = value ?? new List<Invoice>();
    }
    public string RelativePath { get; set; }
    private List<string> _IgnoredFiles = new List<string>();
    public List<string> IgnoredFiles
    {
      get => _IgnoredFiles;
      internal set => _IgnoredFiles = value ?? new List<string>();
    }
  }
}
