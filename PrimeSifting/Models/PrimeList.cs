using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class PrimeList
  {
    private List<int> _numbers = new List<int> {};

    public PrimeList(int userNumber)
    {
      for(int index = 2; index <= userNumber; index++)
      {
        _numbers.Add(index);
      }
    }

    public List<int> GetAll()
    {
      return _numbers;
    }

    // public static void ClearAll()
    // {
    //   _numbers.Clear();
    // }
  }
}