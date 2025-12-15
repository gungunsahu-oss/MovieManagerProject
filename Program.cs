using System;
using MovieProjectImplementation;

class Program
{
    static void Main(string[] args)
    {
        MovieManager manager = new MovieManager();

        Movie h1 = new Movie(1, "Singham", "Chinappa", "Papu", 2025);
        Movie t1 = new Movie(2, "Taare Zamin Par", "dxfgh", "fghj", 2023);

        manager.AddMovie("Hindi", h1);
        manager.AddMovie("Telgu", t1);
        manager.MovieCount();
        Movie h2 = new Movie(3,"Mutasim","fgh","gfchj",2026);
        manager.AddMovie("Hindi", h2);
        Console.WriteLine("Trying to remove movie:");
        manager.RemoveMovie("Hindi", h1);

        manager.MovieCount();
    }
}

