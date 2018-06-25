using System;
using System.Collections.Generic;
using point_of_sale.Interfaces;
using point_of_sale.Models;

namespace point_of_sale
{
  class Program
  {


    static void Main(string[] args)
    {
      bool open = true;
      Console.Clear();
      List<IPurchasable> Menu = new List<IPurchasable>();
      Coffee Mocha = new Coffee("Delicious Mocha", 4.99m);
      Coffee Americano = new Coffee("Americano", 5.10m);
      Coffee Drip = new Coffee("Drip Cofee", 1.99m);
      Coffee Latte = new Coffee("Latte", 4.99m);
      Food Cookie = new Food("Sugar Cookie", 2.99m);
      Menu.Add(Mocha);
      Menu.Add(Americano);
      Menu.Add(Drip);
      Menu.Add(Latte);
      Menu.Add(Cookie);

      List<Order> orders = new List<Order>();
      Order currentOrder = new Order();
      while (open)
      {
        int intSelection;
        Console.WriteLine("Welcome to Coffee Shack! What would you like?");
        for (int i = 0; i < Menu.Count; i++)
        {
          System.Console.WriteLine($"{i}. {Menu[i].Title} -- {Menu[i].Price} ");
        }
        Console.WriteLine("Type 'submit' to complete.");
        Console.WriteLine("Type 'All' to see all orders");
        string selection = Console.ReadLine();
        if (selection.ToLower() == "submit")
        {
          orders.Add(currentOrder);
          currentOrder = new Order();
          Console.Clear();
          System.Console.WriteLine("Order Submitted");
        }
        else if (selection.ToLower() == "all")
        {
          Console.Clear();
          orders.ForEach(o =>
          {
            o.Items.ForEach(i =>
            {
              Console.WriteLine($"{i.Title} -- {i.Price}");
            });
            Console.WriteLine($"Total: ${o.Total}");
          });
        }
        else if (Int32.TryParse(selection, out intSelection))
        {
          if (intSelection > -1 && intSelection < Menu.Count)
          {
            currentOrder.AddItem(Menu[intSelection]);
            Console.Clear();
            System.Console.WriteLine($"Added {Menu[intSelection].Title} to order.");
          }
          else
          {
            Console.Clear();
            System.Console.WriteLine("Invalid selection");
          }
        }
        else
        {
          Console.Clear();
          System.Console.WriteLine("Invalid selection");
        }
      }


    }
  }
}
