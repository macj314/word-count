// using System;
// using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void CounterConstructor_CreateInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("test");
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
    [TestMethod]
    public void SearchTerm_IsDeclaredAsString_String()
    {
      Counter newCounter = new Counter("test");
      string result = "test";
      Assert.AreEqual(result, newCounter.SearchTerm);
    }
  }
}