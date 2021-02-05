using InvoceEvidenceLib;
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
      get => System.IO.Path.Combine(DbPath, "_invoces_db.json");
    }
    public static List<Invoce> Invoces { get; set; } = new List<Invoce>();

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
