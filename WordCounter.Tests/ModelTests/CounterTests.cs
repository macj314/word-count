using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests : IDisposable
  {
    public void Dispose()
    {
      Counter.ClearAll();
    }
    [TestMethod]
    public void CounterConstructor_CreateInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("test", "test sentence");
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
    [TestMethod]
    public void SearchTermAndWordList_AreDeclared_StringAndListOfStrings()
    {
      Counter newCounter = new Counter("test", "test sentence");

      string searchTerm = "test";
      string sentence = "test sentence";

      Assert.AreEqual(searchTerm, newCounter.SearchTerm);
      Assert.AreEqual(sentence, newCounter.Sentence);
    }
    [TestMethod]
    public void GetAll_ReturnsAStringDisplayingSearchTermAndSentence_String()
    {
      Counter newCounter = new Counter("cat", "cat in play");


      string result = "Your search word is: 'cat' and your sentence is: 'cat in play'";

      Assert.AreEqual(result, newCounter.GetAll());
    }
    [TestMethod]
    public void FindRepeats_ReturnsTheCorrectNumberOfRepeatingWordsInSentence_Int()
    {
      Counter newCounter = new Counter("cats", "several cats are playing with other cats");
      Assert.AreEqual(2, newCounter.FindRepeats());
    }
  }
}