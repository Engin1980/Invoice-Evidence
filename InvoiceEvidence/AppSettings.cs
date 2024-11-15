using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceEvidence
{
  public class AppSettings
  {
    private class ColorJsonConverter : JsonConverter
    {
      public override bool CanConvert(Type objectType)
      {
        return objectType == typeof(Color);
      }

      public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
      {
        if (reader.TokenType == JsonToken.String)
        {
          string colorString = (string)reader.Value;
          return ColorTranslator.FromHtml(colorString); // Converts HTML color codes to System.Drawing.Color
        }

        throw new JsonSerializationException("Invalid color format.");
      }

      public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
      {
        if (value is Color color)
        {
          string colorString = ColorTranslator.ToHtml(color); // Converts System.Drawing.Color to HTML color code
          writer.WriteValue(colorString);
        }
        else
        {
          throw new JsonSerializationException("Expected Color object.");
        }
      }
    }

    public string TempDirectory { get; set; } = null!;
    
    public string TesseractDirectory { get; set; } = null!;
    
    public string TesseractLanguages { get; set; } = null!;
    
    public string GhostscriptLocation { get; set; } = null!;
    
    public string DbPath { get; set; } = null!;
    
    public string LastDatabaseFolder { get; set; } = null!;
    
    public bool MainFormExtendedView { get; set; }

    [JsonConverter(typeof(ColorJsonConverter))]
    public Color InvoiceOldBackColor { get; set; }
    
    public int InvoiceOldDaysCount { get; set; }
    
    [JsonConverter(typeof(ColorJsonConverter))]
    public Color InvoiceNewBackColor { get; set; }
    
    public double InvoiceNewDaysCount { get; set; }
    
    public string SupportedExtension { get; set; } = null!;
    
    public int MainFormVerticalScrollbarPlaceholderWith { get; set; }

    public void Save()
    {
      throw new NotImplementedException();
    }

    private const string CONFIGURATION_FILE = "appsettings.json";

    public static AppSettings Load()
    {
      AppSettings ret;

      try
      {
        ret = JsonConvert.DeserializeObject<AppSettings>(System.IO.File.ReadAllText(CONFIGURATION_FILE))
          ?? throw new ApplicationException("Configuration file loading returned null.");
      }
      catch (Exception ex)
      {
        throw new ApplicationException("Failed to load configuration file from " + CONFIGURATION_FILE, ex);
      }

      return ret;
    }
  }
}
