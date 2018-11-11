namespace Helpers
{
  using System.Collections.Generic;
  using System.Linq;
  using System;
  using Model;

  public static class Commons
  {
    public static bool Any(this IEnumerable<Movie> movies, Func<Movie, int, IList<Movie>, bool> predicate)
    {
      var moviesList = movies.ToList();
      for (var i = 0; i < moviesList.Count; i++)
      {
        var result = predicate(moviesList[i], i, moviesList);
        if (result)
        {
          return true;
        }
      }
      return false;
    }
    public static bool IsAnyOverlapExists(this Movie movie1, int index1, IList<Movie> movies)
    {
      for (var i = 0; i < movies.Count; i++)
      {
        if (i != index1)
        {
          var movie2 = movies[i];
          bool overlaps = Movie.Overlaps(movie1, movie2);
          if (overlaps)
          {
            return true;
          }
        }
      }

      return false;
    }
  }

}