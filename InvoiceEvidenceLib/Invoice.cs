using System;
using System.ComponentModel;
using System.Linq;

namespace InvoiceEvidenceLib
{
  public class Invoice
  {
    public string FileName { get; set; }
    public string ShopName { get; set; }
    public string Number { get; set; }
    public string OrderNumber { get; set; }
    public string Keywords { get; set; }
    public DateTime Date { get; set; }
    public BindingList<InvoiceItem> Items { get; set; } = new BindingList<InvoiceItem>();
    public string Comment { get; set; }

    public double TotalPrice
    {
      get => Items.Sum(q => q.Amount);
    }

    public string ItemsOverview
    {
      get => string.Join("; ", Items.Select(q => q.Label));
    }


    public Invoice()
    {

    }

    public Invoice(string fileName, int presetItemsCount = 7)
    {
      FileName = fileName;
      this.AppendEmptyItems(presetItemsCount);
    }

    public void DiscardEmptyItems()
    {
      var toDel = Items
        .Where(q => string.IsNullOrWhiteSpace(q.Label) &&
                    string.IsNullOrWhiteSpace(q.Keywords) &&
                    q.Amount == 0).ToList();
      toDel.ForEach(q => Items.Remove(q));
    }

    public void AppendEmptyItems(int count = 7)
    {
      while (Items.Count < count)
        Items.Add(new InvoiceItem());
    }
  }
}
