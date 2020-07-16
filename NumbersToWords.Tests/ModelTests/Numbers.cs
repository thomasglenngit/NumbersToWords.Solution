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

    [TestMethod]
    public void GetNumbers19_MatchesNumberWithString_Dictionary()
    {
      Dictionary<int, string> testNumbers19 = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"} };
      Numbers newNumbers = new Numbers();
      Dictionary<int, string> result = newNumbers.Numbers19;
      CollectionAssert.AreEqual(testNumbers19, result);

    }

    [TestMethod]
    public void GetNumbers99_MatchesNumberWithString_Dictionary()
    {
      Dictionary<int, string> testNumbers99 = new Dictionary<int, string>() { {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"} };
      Numbers newNumbers = new Numbers();
      Dictionary<int, string> result = newNumbers.Numbers99;
      CollectionAssert.AreEqual(testNumbers99, result);
    }
  }
}