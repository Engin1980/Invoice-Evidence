using System;
using System.ComponentModel;
using System.Reflection;

namespace InvoiceEvidence.Properties
{
  internal sealed partial class Settings : ICustomTypeDescriptor
  {
    public String GetClassName() => TypeDescriptor.GetClassName(this, true);

    public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);

    public String GetComponentName()
    {
      return TypeDescriptor.GetComponentName(this, true);
    }

    public TypeConverter GetConverter()
    {
      return TypeDescriptor.GetConverter(this, true);
    }

    public EventDescriptor GetDefaultEvent()
    {
      return TypeDescriptor.GetDefaultEvent(this, true);
    }

    public PropertyDescriptor GetDefaultProperty()
    {
      return TypeDescriptor.GetDefaultProperty(this, true);
    }

    public object GetEditor(Type editorBaseType)
    {
      return TypeDescriptor.GetEditor(this, editorBaseType, true);
    }

    public EventDescriptorCollection GetEvents(Attribute[] attributes)
    {
      return TypeDescriptor.GetEvents(this, attributes, true);
    }

    public EventDescriptorCollection GetEvents()
    {
      return TypeDescriptor.GetEvents(this, true);
    }

    public object GetPropertyOwner(PropertyDescriptor pd)
    {
      return this;
    }

    public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      return GetProperties();
    }

    public PropertyDescriptorCollection GetProperties()
    {
      // Create a new collection object PropertyDescriptorCollection
      var pds = new PropertyDescriptorCollection(null);

      pds.Add(SimplePropertyDescriptor.Create("TesseractDirectory",
        category: "Tesseract",
        displayName: "Tesseract directory",
        description: "Directory with tesseract."));
      pds.Add(SimplePropertyDescriptor.Create("TesseractLanguages",
        category: "Tesseract",
        displayName: "Tesseract languages",
        description: "Supported languages in tesseract format (e.g., eng+fra). Training files must be available" +
        "in tesseract 'tessdata' directory for every language."));
      pds.Add(SimplePropertyDescriptor.Create("TempDirectory",
        category: "Behavior",
        displayName: "Temp directory",
        description: "Directory where Tesseract stores temporal image files. SSD/RamDisk location preffered."));
      pds.Add(SimplePropertyDescriptor.Create("InvoiceNewBackColor",
        category: "Invoices",
        displayName: "New invoice backcolor",
        description: "Background color for new invoices, RGB format."));
      pds.Add(SimplePropertyDescriptor.Create("InvoiceOldBackColor",
        category: "Invoices",
        displayName: "Old invoice backcolor",
        description: "Background color for old invoices, RGB format."));
      pds.Add(SimplePropertyDescriptor.Create("InvoiceOldDaysCount",
        category: "Invoices",
        displayName: "Old invoices - minimal days",
        description: "Minimal number of days from 'Date' of an invoice to be considered as old."));
      pds.Add(SimplePropertyDescriptor.Create("InvoiceNewDaysCount",
        category: "Invoices",
        displayName: "New invoices - maximal days",
        description: "Maximal number of days from 'Date' of an invoice to be considered as new."));
      pds.Add(SimplePropertyDescriptor.Create("MainFormExtendedView",
        category: "View",
        displayName: "Use extended view",
        description: "If 'True', more detailed view is used for invoce overview. If 'False', simple grid view is used" +
        "for invoices."));
      pds.Add(SimplePropertyDescriptor.Create("MainFormVerticalScrollbarPlaceholderWith",
        category: "View",
        displayName: "Vertical scrollbar placeholder width",
        description: "Width (in pixels) reserved for vertical scrollbar on the right side of main form."));
      pds.Add(SimplePropertyDescriptor.Create("SupportedExtension",
        category: "Behavior",
        displayName: "Supported file extensions",
        description: "File extension separated by ; character."));
      pds.Add(SimplePropertyDescriptor.Create("GhostscriptLocation",
        category: "GhostScript",
        displayName: "Ghostscript location",
        description: "Folder where gswin64c.exe is located."));
      pds.Add(SimplePropertyDescriptor.Create("LastDatabaseFolder",
        category: "Behavior",
        displayName: "Last database folder",
        description: "The last folder set as database folder with invoices."));

      // add the default ones
      PropertyDescriptorCollection tmp = TypeDescriptor.GetProperties(typeof(Settings));
      for (int i = 0; i < tmp.Count; i++)
      {
        PropertyDescriptor tmpI = tmp[i];
        if (pds.Find(tmpI.Name, true) == null)
        {
          pds.Add(tmpI);
        }
      }


      return pds;
    }

    private class SimplePropertyDescriptor : PropertyDescriptor
    {
      public static SimplePropertyDescriptor Create(string propertyName, string category = null,
        string description = null,
        string displayName = null)
      {
        PropertyInfo pi = typeof(Settings).GetProperty(propertyName);
        PropertyDescriptor pd = TypeDescriptor.GetProperties(pi.DeclaringType).Find(pi.Name, true);
        SimplePropertyDescriptor ret = new SimplePropertyDescriptor(
          propertyName, pd, category, displayName, description);
        return ret;
      }

      private PropertyDescriptor pd;
      private string category;
      private string description;
      private string displayName;

      private SimplePropertyDescriptor(string propertyName, PropertyDescriptor pd,
        string category,
        string displayName,
        string description) : base(pd)
      {
        this.pd = pd;
        this.category = category;
        this.displayName = displayName;
        this.description = description;
      }

      public override string DisplayName => displayName != null ? displayName : base.DisplayName;

      public override string Description => description != null ? description : base.Description;


      public override Type ComponentType => pd.ComponentType;

      public override bool IsReadOnly => pd.IsReadOnly;

      public override Type PropertyType => pd.PropertyType;

      public override bool CanResetValue(object component) => pd.CanResetValue(component);

      public override object GetValue(object component) => pd.GetValue(component);

      public override void ResetValue(object component) => pd.ResetValue(component);

      public override void SetValue(object component, object value) => pd.SetValue(component, value);

      public override bool ShouldSerializeValue(object component) => pd.ShouldSerializeValue(component);

      public override string Category => category != null ? category : base.Category;
    }
  }
}
