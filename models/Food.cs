using point_of_sale.Interfaces;

namespace point_of_sale.Models
{
  public class Food : IPurchasable
  {
    public string Title { get; set; }
    public decimal Price { get; set; }

    public Food(string title, decimal price)
    {
        Title = title;
        Price = price;
    }
  }
}