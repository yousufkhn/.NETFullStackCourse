using System;

namespace MovieLibrary
{
    public class FilmLibrary
    {
        private List<IFilm> _films;

        public FilmLibrary()
        {
            _films = new List<IFilm>();
        }

        public void AddFilm(IFilm film)
        {
            _films.Add(film);
        }
        public void RemoveFilm(string title)
        {
            _films.RemoveAll(f => f.Title.Equals(title));
        }

        // public List<IFilm> GetFilms() // this is one way and its not wrong
        // {
        //     // return _films; // wrong way because this way the user can now directly interact with out private films list, and can even empty it so this is loss of 
        //     return new List<IFilm>(_films); // this is like sending a copy back
        // }

        public IEnumerable<IFilm> GetFilms() // this is a better way and lets user iterate over films while not letting them modify it directly
        {
            return _films;
        }
        public List<IFilm> SearchFilms(string query)
        {
            return _films.FindAll(f => f.Title.Equals(query) || f.Director.Equals(query));
        }

        public int GetTotalFilmCount()
        {
            return _films.Count;
        }


    }
}