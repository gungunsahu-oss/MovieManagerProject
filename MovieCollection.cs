using System;
using System.Collections.Generic;

namespace MovieProjectImplementation
{
    class MovieCollection
    {
        Dictionary<string, Dictionary<int, Movie>> movies =
            new Dictionary<string, Dictionary<int, Movie>>();

        public void AddMovie(string lang, Movie movie)
        {
            if (!movies.ContainsKey(lang))
            {
                movies[lang] = new Dictionary<int, Movie>();
            }

            if (!movies[lang].ContainsKey(movie.Id))
            {
                movies[lang].Add(movie.Id, movie);
            }
        }

        public void RemoveMovie(Movie movie, string lang)
        {
            if (movies.ContainsKey(lang) && movies[lang].ContainsKey(movie.Id))
            {
                movies[lang].Remove(movie.Id);
            }
            else
            {
                Console.WriteLine("Movie not exist");
            }
        }

        public int MovieCount()
        {
            int count = 0;
            foreach (var num in movies.Values)
            {
                count += num.Count;
            }
            return count;
        }
    }
}

