using InvoiceEvidenceLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceEvidence
{
  static class Program
  {
    public static string DbPath { get; set; } = @"C:\Users\Vajgl\OneDrive - Ostravska univerzita\Synchronized\Faktury";
    public static string DbFile
    {
      get => System.IO.Path.Combine(DbPath, "_invoices_db.json");
    }
    public static Db Db { get; set; } = new Db();
    public static List<Invoice> Invoices { get => Program.Db.Invoices; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Forms.FrmMain());
    }
  }
}
