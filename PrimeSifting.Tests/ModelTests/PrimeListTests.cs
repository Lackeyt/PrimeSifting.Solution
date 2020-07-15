using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeListTests
  {

    [TestMethod]
    public void UserNumberConstructor_CreatesInstanceOfUserNumber_UserNumber()
    {
      UserNumber newItem = new UserNumber(5);
      Assert.AreEqual(typeof(UserNumber), newItem.GetType());
    }

    [TestMethod]
    public void UserNumberConstructor_ReturnsNumberList_ListInt()
    {
      UserNumber newNumber = new UserNumber(5);
      List<int> listAnswer = new List<int> {2,3,4,5};
      List<int> result = newNumber.GetAll();
      CollectionAssert.AreEqual(listAnswer, result);
    }

    [TestMethod]
    public void UserNumberConstructor_ReturnsListOfSmallerPrimes_ListInt()
    {
      UserNumber newNumber = new UserNumber(5);
      List<int> listAnswer = new List<int> {2,3,5};
      List<int> result = newNumber.PrimeList();
      CollectionAssert.AreEqual(listAnswer, result);
    }
  }
}