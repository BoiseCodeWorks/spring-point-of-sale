using System.Collections.Generic;
using point_of_sale.Interfaces;

namespace point_of_sale.Models
{
  public class Order
  {
    public List<IPurchasable> Items { get; set; }
    public decimal Total {get; set;}



    public void AddItem(IPurchasable item)
    {
      Items.Add(item);
      Total += item.Price;
    }



    public Order()
    {
        Items = new List<IPurchasable>();
        Total = 0;
    }
  }
}