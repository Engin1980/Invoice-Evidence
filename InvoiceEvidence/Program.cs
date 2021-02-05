using InvoiceEvidenceLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  static class Program
  {
    public static string DbPath { get; set; } = "R:\\";
    public static string DbFile
    {
      get => System.IO.Path.Combine(DbPath, "_invoices_db.json");
    }
    public static List<Invoice> Invoices { get; set; } = new List<Invoice>();

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMain());
    }
  }
}
