using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
            this.MovieDTO = new MovieDTO();
            this.RecomendedMovies = new MoviesDTO();
            this.UpComingMovies = new MoviesDTO();
        }
        public MovieDTO MovieDTO { get; set; }
        public MoviesDTO RecomendedMovies { get; set; }
        public MoviesDTO UpComingMovies { get; set; }
        public MoviesDTO GetMoviesByGenreAndPageNo { get; set; }
    }

    public class MovieTrailor
    {
        public string VideoKey { get; set; }
    }
}