using System;
using System.Numerics;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Tyler Davis");

      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int    

      String faveNumber = Console.ReadLine();

      int newInt = Convert.ToInt32(faveNumber);

      Console.Write("The number that you wrote was " + newInt + "\n");

      //Now let's understand the difference between a double and a decimal

      //just a standard double
      double standardDouble = 39.76876;

      decimal decimalNotDouble = 489872.76m;

      float standardFloat = 489872.76f;

      // both of these are valid double declarations
      double doubleDeclareOne = 39.766;
      double doubleDeclareTwo = 42.686d;

      Console.Write(standardDouble + " " + decimalNotDouble + " " + standardFloat + " " + doubleDeclareOne + " " + doubleDeclareTwo);
     }
  }
}