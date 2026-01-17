using MovieStock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStock{
	public class Program{
		public static List<Movie> MovieList;

		public void AddMovie(string movieDetails){
			string[] strArr = movieDetails.Split(',');
			Movie m = new Movie();
			m.Title = strArr[0];
			m.Artist = strArr[1];
			m.Genre = strArr[2];
			m.Ratings = Int32.Parse(strArr[3]);
			MovieList.Add(m);
		}

		public List<Movie> ViewMoviesByGenre(string genre){
			List<Movie> foundMovies = new List<Movie>();
			foreach(Movie m in MovieList){
				if(m.Genre.Equals(genre)){
					foundMovies.Add(m);
				}
			}
			return foundMovies;
		}
		
		public List<Movie> ViewMoviesByRatings(){
			return MovieList.OrderBy(m=>m.Ratings).ToList();
		}

		public static void Main(string[] args){
			Program p = new Program();
			MovieList = new List<Movie>();
			// we will take 5 movies for this eg
			for(int i = 0;i<5;i++){
				Console.Write($"Enter movie name,artist,genre,ratings {i} : ");
				string input = Console.ReadLine();
				p.AddMovie(input);
			}

			Console.WriteLine("Now we will view movies by genre");
			Console.Write("Enter the genre you want to see movies of : ");
			string genre = Console.ReadLine();
			List<Movie> moviesByGenre = p.ViewMoviesByGenre(genre);
			if(moviesByGenre!=null){
				foreach(Movie m in moviesByGenre){
					Console.WriteLine(m.Title + " " + m.Artist + " " + m.Genre);
				}
			}
			else{
				Console.WriteLine($"No Movies found in genre {genre}");
			}

			Console.WriteLine("Now we will sort movies by ratings");
			List<Movie> moviesByRatings = p.ViewMoviesByRatings();
			foreach(Movie m in moviesByRatings){
				Console.WriteLine(m.Title + " " + m.Artist + " " + m.Genre);
			}

				
		}	
	}
}