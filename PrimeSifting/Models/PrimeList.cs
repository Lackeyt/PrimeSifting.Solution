using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class UserNumber
  {
    public int UserInput;
    private List<int> _numbers = new List<int> {};

    public UserNumber(int num)
    {
      UserInput = num;
      for(int index = 2; index <= num; index++)
      {
        _numbers.Add(index);
      }
    }

    public List<int> GetAll()
    {
      return _numbers;
    }

    public List<int> PrimeList()
    {
      // int prime = 2;
      // while(prime < this.UserInput)
      // {
      //   foreach (int element in _numbers)
      //   {
      //     if(element > prime && element % prime == 0)
      //     {
      //       _numbers.Remove(element);
      //     }
      //   }
      //   prime += 1;
      // }
      return _numbers;
    }
  }
}