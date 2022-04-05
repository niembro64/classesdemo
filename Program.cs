using System;

namespace classesdemo
{
  class Program
  {
    static void Main(string[] args)
    {

      Drink d1 = new Drink("coffee", "brown", false, 95.5, 200);
      Console.Write($"I am drinking {d1.name} \n");
      d1.name = "Tea";
      Console.Write($"I am drinking {d1.name} \n");

      Drink d2 = new Drink("coke", "brown", 33.5, 200);
      Console.Write($"I am drinking {d1.name} \n");
      Console.Write($"Carbonated : {d2.isCarbonated}");
    }
  }
}

