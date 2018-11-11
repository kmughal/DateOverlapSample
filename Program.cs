namespace csharpconsole
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using Helpers;
    using Model;

    class Program
    {
        static void Main(string[] args)
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            var movies = new Movie[]
            {
                new Movie(DateTime.Parse("1/1/2015 20:00", format), DateTime.Parse("1/1/2015 21:30", format)),
                new Movie(DateTime.Parse("1/1/2015 21:30", format), DateTime.Parse("1/1/2015 23:00", format)),
                new Movie(DateTime.Parse("1/1/2015 23:10", format), DateTime.Parse("1/1/2015 23:30", format))
            };

            Console.WriteLine(CanViewAll(movies.ToList()));

        }

        public static string CanViewAll(List<Movie> movies) =>
        $"{ (movies.Any(Commons.IsAnyOverlapExists) ? "Can't view" : "Can view")}";
         
    }

}