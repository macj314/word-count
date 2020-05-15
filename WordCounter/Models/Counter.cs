namespace WordCounter.Models
{
  public class Counter
  {
    public string SearchTerm { get; set; }
    public string Sentence { get; set; }
    public Counter(string searchterm, string sentence)
    {
      SearchTerm = searchterm;
      Sentence = sentence;
    }
  }
}