using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersTests
  {
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfNumber_Numbers()
    {
      Numbers newNumbers = new Numbers();
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType()); 
    }
  }
}