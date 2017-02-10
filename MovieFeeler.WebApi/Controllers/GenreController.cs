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
    public class GenreController : ApiController
    {
        private readonly IGenreRestApi _genreApi = null;
        public GenreController()
        {
            _genreApi = new GenreRestApi();
        }

        // Get api/genres
        public GenresDTO GetGenres()
        {
            var genres = _genreApi.GetGenres();
            return genres;
        }


        // Get api/values/5
        //public MoviesDTO GetMoviesByGenreAndPageNo(int pageno, int genreId)
        //{
        //    var movies = _genreApi.GetMoviesByGenreAndPageNo(pageno, genreId);
        //    return movies;
        //}


    }
}
