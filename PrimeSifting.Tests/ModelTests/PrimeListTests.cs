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
      PrimeList newItem = new PrimeList();
      Assert.AreEqual(typeof(PrimeList), newItem.GetType());
    }
  }
}