using point_of_sale.Interfaces;

namespace point_of_sale.Models
{
  public class Coffee : IPurchasable
  {
    public string Title { get; set; }
    public decimal Price { get; set; }

    public string Size { get; set; }

    public Coffee(string title, decimal price)
    {
        Title = title;
        Price = price;
    }
  }
}