namespace WordCounter.Models
{
  public class Counter
  {
    public string SearchTerm { get; set; }
    public Counter(string searchterm)
    {
      SearchTerm = searchterm;
    }
  }
}