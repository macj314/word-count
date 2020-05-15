using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string SearchTerm { get; set; }
    public string Sentence { get; set; }
    private static List<string> _wordList = new List<string>{};
    public Counter(string searchterm, string sentence)
    {
      SearchTerm = searchterm;
      Sentence = sentence;
      string[] stringArray = Sentence.ToLower().Split();
      _wordList.AddRange(stringArray);
    }
    public string GetAll()
    {
      return $"Your search word is: '{SearchTerm}' and your sentence is: '{Sentence}'";
    }
    public static void ClearAll()
    {
      _wordList.Clear();
    }

    public string RemovePunctuation(string value)
    {
        int removeFromStart = 0;
        for (int i = 0; i < value.Length; i++)
        {
                    Console.WriteLine(1);
            if (char.IsPunctuation(value[i]))
            {
                removeFromStart++;
            }
            else
            {
                break;
            }
        }
        int removeFromEnd = 0;
        for (int i = value.Length - 1; i >= 0; i--)
        {
                    Console.WriteLine(2);
          if (char.IsPunctuation(value[i]))
          {
              removeFromEnd++;
          }
          else
          {
              break;
          }
        }
        if (removeFromStart == 0 &&
            removeFromEnd == 0)
        {
          Console.WriteLine(3);
            return value;
        }
        if (removeFromStart == value.Length &&
            removeFromEnd == value.Length)
        {
          Console.WriteLine(4);
          return "";
        }
        Console.WriteLine(5);
        return value.Substring(removeFromStart,
            value.Length - removeFromEnd - removeFromStart);
    }
    public int FindRepeats()
    {
      int count = 0;
      for (int i = 0; i < _wordList.Count; i++)
      {       
        // Console.WriteLine("i = " + i + " " + _wordList[i]);
        _wordList[i] = this.RemovePunctuation(_wordList[i]);
        // Console.WriteLine(_wordList[i]);
        if (_wordList[i] == SearchTerm)
        {
          count++;
        }
      }
      return count;
    }
  }
}