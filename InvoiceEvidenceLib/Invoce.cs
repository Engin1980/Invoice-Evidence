using System;
using System.ComponentModel;
using System.Linq;

namespace InvoiceEvidenceLib
{
  public class Invoce
  {
    public string FileName { get; set; }
    public string ShopName { get; set; }
    public string Number { get; set; }
    public string Keywords { get; set; }
    public DateTime Date { get; set; }
    public BindingList<InvoceItem> Items { get; set; } = new BindingList<InvoceItem>();
    public string Comment { get; set; }

    public string ItemsOverview
    {
      get => string.Join("; ", Items.Select(q => q.Label));
    }


    public Invoce()
    {

    }

    public Invoce(string fileName, int presetItemsCount)
    {
      FileName = fileName;
      for (int i = 0; i < presetItemsCount; i++)
      {
        Items.Add(new InvoceItem());
      }
    }

    public void DiscardEmptyItems()
    {
      var toDel = Items
        .Where(q => string.IsNullOrWhiteSpace(q.Label) &&
                    string.IsNullOrWhiteSpace(q.Keywords) &&
                    q.Amount == 0).ToList();
      toDel.ForEach(q => Items.Remove(q));
    }
  }
}
