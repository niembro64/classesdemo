using System;

namespace classesdemo
{
  public class Drink
  {
    // Fields - attributes of class
    public string name;
    public string color;
    public bool isCarbonated;
    public double temperature;
    public int calories;

    public Drink(string n, string c, bool isC, double t, int cal)
    {
      name = n;
      color = c;
      isCarbonated = isC;
      temperature = t;
      calories = cal;
    }

    public Drink(string n, string c, double t, int cal)
    {
      name = n;
      color = c;
      isCarbonated = true;
      temperature = t;
      calories = cal;
    }

  }
}