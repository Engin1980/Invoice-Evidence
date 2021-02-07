//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InvoiceEvidence.Properties
//{
//  internal sealed partial class Settings : ICustomTypeDescriptor
//  {
//    public String GetClassName()
//    {
//      return TypeDescriptor.GetClassName(this, true);
//    }

//    public AttributeCollection GetAttributes()
//    {
//      return TypeDescriptor.GetAttributes(this, true);
//    }

//    public String GetComponentName()
//    {
//      return TypeDescriptor.GetComponentName(this, true);
//    }

//    public TypeConverter GetConverter()
//    {
//      return TypeDescriptor.GetConverter(this, true);
//    }

//    public EventDescriptor GetDefaultEvent()
//    {
//      return TypeDescriptor.GetDefaultEvent(this, true);
//    }

//    public PropertyDescriptor GetDefaultProperty()
//    {
//      return TypeDescriptor.GetDefaultProperty(this, true);
//    }

//    public object GetEditor(Type editorBaseType)
//    {
//      return TypeDescriptor.GetEditor(this, editorBaseType, true);
//    }

//    public EventDescriptorCollection GetEvents(Attribute[] attributes)
//    {
//      return TypeDescriptor.GetEvents(this, attributes, true);
//    }

//    public EventDescriptorCollection GetEvents()
//    {
//      return TypeDescriptor.GetEvents(this, true);
//    }

//    public object GetPropertyOwner(PropertyDescriptor pd)
//    {
//      return this;
//    }

//    public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
//    {
//      return GetProperties();
//    }

//    public PropertyDescriptorCollection GetProperties()
//    {
//      // Create a new collection object PropertyDescriptorCollection
//      var pds = new PropertyDescriptorCollection(null);

//      // Iterate the list of employees
//      for (int i = 0; i < this.List.Count; i++)
//      {
//        // For each employee create a property descriptor 
//        // and add it to the 
//        // PropertyDescriptorCollection instance
//        CollectionPropertyDescriptor pd = new
//                      CollectionPropertyDescriptor(this, i);
//        pds.Add(pd);
//      }
//      return pds;
//    }
//  }
//}
