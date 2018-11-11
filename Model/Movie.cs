namespace Model
{
  using System;

  public class Movie
  {
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public Movie(DateTime start, DateTime end)
    {
      this.Start = start;
      this.End = end;
    }

    public static bool Overlaps(Movie item1, Movie item2) =>
      item1.Start > item2.Start && item1.Start < item2.End;

    public override string ToString()
    {
      return Start.ToString() + " - " + End.ToString();
    }
  }
}