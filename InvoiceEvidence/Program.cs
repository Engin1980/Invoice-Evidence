using InvoiceEvidence.Forms;
using InvoiceEvidenceLib;
using Microsoft.Extensions.Configuration;

namespace InvoiceEvidence
{
  internal static class Program
  {
    public static AppSettings AppSettings { get; private set; } = null!;
    public static string DbPath { get; set; } = null!;
    public static string DbFile
    {
      get => System.IO.Path.Combine(DbPath, "_invoices_db.json");
    }
    public static Db Db { get; set; } = new Db();
    public static List<Invoice> Invoices { get => Program.Db.Invoices; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Program.AppSettings = AppSettings.Load();
      Program.DbPath = Program.AppSettings.LastDatabaseFolder;

      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new FrmMain());
    }
  }
}