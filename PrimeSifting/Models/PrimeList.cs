using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class UserNumber
  {
    public int UserInput;
    public List<int> _numbers = new List<int> {};

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
      int prime = 2;
      //List<int> values = this._numbers;
      while(prime < this.UserInput)
      {
        for(int index=0; index < this._numbers.Count; index++)
        {
          if(this._numbers[index] > prime && this._numbers[index] % prime == 0)
          {
            this._numbers.Remove(this._numbers[index]);
          }
        }
        prime += 1;
      }
      return this._numbers;
    }
  }
  
}