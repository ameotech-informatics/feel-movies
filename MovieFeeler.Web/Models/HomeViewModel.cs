using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{

    public class HomeViewModel
    {
        public HomeViewModel()
        {
            NowPlayingMovies = new MoviesDTO();
            UpcomingMovies = new MoviesDTO();
            TopRatedMovies = new MoviesDTO();
            PopularMovies = new MoviesDTO();
    
        }
        public MoviesDTO PopularMovies { get; set; }
        public MoviesDTO NowPlayingMovies { get; set; }
        public MoviesDTO UpcomingMovies { get; set; }
        public MoviesDTO TopRatedMovies { get; set; }
    }
}