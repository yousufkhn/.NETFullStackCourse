// See https://aka.ms/new-console-template for more information
using MovieLibrary;
Console.WriteLine("Hello, World!");

FilmLibrary library = new FilmLibrary();

library.AddFilm(new Film("Movie" , "Yousuf",2020));
library.AddFilm(new Film("Movie2" , "Rahul",2020));
library.AddFilm(new Film("Movi" , "Aaysha",2020));

System.Console.WriteLine(
    "All Films: "
);

foreach(var film in library.GetFilms())
{
    System.Console.WriteLine(film.Title);
}

Console.WriteLine("\nTotal films:");
Console.WriteLine(library.GetTotalFilmCount());

Console.WriteLine("\nSearch results for 'Yousuf':");
var results = library.SearchFilms("Yousuf");

foreach (var film in results)
{
    Console.WriteLine(film.Title);
}