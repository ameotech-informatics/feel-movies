using MovieFeeler.DTO;
using MovieFeeler.Rest.Client;
using MovieFeeler.Rest.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieFeeler.WebApi.Controllers
{
    public class MovieController : ApiController
    {
        private readonly IMovieRestApi _movieApi = null;
        public MovieController()
        {
            _movieApi = new MovieRestApi();
        }

        [HttpGet]
       
        // api/Movie/GetLatestMovies
        public MovieDTO GetLatestMovies()
        {
            var movies = _movieApi.GetLatestMovies();
            return movies;
        }

        [HttpGet]
        // api/Movie/GetLatestMovies/{page}
        public MoviesDTO GetTopRatedMovies(int? page = 1)
        {
            var movies = _movieApi.GetTopRatedMovies(page);
            return movies;
        }

        [HttpGet]
        public MoviesDTO GetPopulorMovies()
        {
            var movies = _movieApi.GetPopularMovies();
            return movies;
        }

        [HttpGet]
        public MoviesDTO GetUpComingMovies(int? page = 1)
        {
            var movies = _movieApi.GetUpComingMovies(page);
            return movies;
        }

       [HttpGet]
        public MoviesDTO GetRecomendedMoviesByMovieId(int movieId)
        {
            var movies = _movieApi.GetRecomendedMoviesByMovieId(movieId);
            return movies;
        }

       [HttpGet]
        public MoviesDTO GetNowPlayingMovies()
        {
            var movies = _movieApi.GetNowPlayingMovies();
            return movies;
        }

        [HttpGet]
        public MovieDTO GetMovieDetail(int movieId)
        {
            var movie = _movieApi.GetMovieDetail(movieId);
            return movie;
        }

       [HttpGet]
        public TrailerDTO GetTrailers(int movieId)
        {
            var video = _movieApi.GetTrailers(movieId);
            return video;
        }
    }
}
