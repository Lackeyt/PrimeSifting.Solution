using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeListTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   PrimeList.ClearAll();
    // }

    [TestMethod]
    public void PrimeListConstructor_CreatesInstanceOfPrimeList_PrimeList()
    {
      PrimeList newItem = new PrimeList(5);
      Assert.AreEqual(typeof(PrimeList), newItem.GetType());
    }

    [TestMethod]
    public void PrimeListConstructor_ReturnsNumberList_ListInt()
    {
      //arrange
      PrimeList newNumber = new PrimeList(5);
      List<int> listAnswer = new List<int> {2,3,4,5};
      //act
      List<int> result = newNumber.GetAll();
      CollectionAssert.AreEqual(listAnswer, result);
    }
  }
}