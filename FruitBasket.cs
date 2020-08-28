Using System;
Using System.Collections.Generic;

class FruitBasket

  public Dictionary<string, int> fruitTree = new Dictionary<string, int>() {
    {"orange", 3}, {"apple", 3}, {"peach", 3}
  };
  public Dictionary<string, int> fruitBasket = new Dictionary<string, int>() {
    {"orange", 0}, {"apple", 0}, {"peach", 0}
  };
  {
    static void Main()
    {
      Console.WriteLine("You stand in a beautiful orchard, equidistant between \
      three fruit trees - an apple, an orange, and a peach.")
      string responsePick = Console.ReadLine("Would you like to pick a fruit \
      and put it in your basket? [y/n]")
      if responsePick == "y" {
        PickFruit()
      }
      Console.WriteLine("You have \
      " + fruitBasket["orange"].ToString() + "oranges, \
      " + fruitBasket["apple"].ToString() + "apples, and \
      " + fruitBasket["peach"].ToString() + "peaches in your basket.")
      string responseEat = Console.ReadLine("Would you like to eat one? [y/n]")
      if responseEat == "y" {
        EatFruit()
      }
      string startOver = Console.ReadLine("Would you like to stay a while longer? [y/n]")
      if startOver == "y" {
        Main()
      }
    }

    static void PickFruit() 
    {
      string responsePickWhichFruit = Console.ReadLine("Choose 'apple', 'orange', or 'peach'");
      if fruitTree[responsePickWhichFruit] == 0 
      {
        Console.WriteLine("Hmm, there are no ripe fruit left on that tree.");
        return
      }
      else 
      {
        fruitTree[responsePickWhichFruit] = fruitTree[responsePickWhichFruit] - 1;
        fruitBasket[responsePickWhichFruit] = fruitBasket[responsePickWhichFruit] + 1;
        return
      }

    }
    static void EatFruit() 
    {
      string responseEatWhichFruit = Console.ReadLine("Choose 'apple', 'orange', or 'peach'");
      if fruitBasket[responseEatWhichFruit] == 0 
      {
        Console.WriteLine("Hmm, you don't have any " + fruitBasket[responseEatWhichFruit] + " left")
        return
      }
      else
      {
        fruitBasket[responseEatWhichFruit] = fruitBasket[responseEatWhichFruit] - 1;
        Console.WriteLine("It's delicious!")
        return
      }
    }

  }