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
      string[] stringArray = sentence.Split();
      _wordList.AddRange(stringArray);
    }
    public string GetAll()
    {
      return $"Your search word is: '{SearchTerm}' and your sentence is: '{Sentence}'" + _wordList;
    }
  }
}