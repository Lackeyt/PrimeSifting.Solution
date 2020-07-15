using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Test Number Entry:");
      int userInput = Int32.Parse(Console.ReadLine());
      UserNumber testNum = new UserNumber(userInput);
      List<int> result = testNum.PrimeList();
      foreach(int element in result)
      {
        Console.WriteLine(element);
      }
    }
  }
}
