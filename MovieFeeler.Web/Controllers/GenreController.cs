using MovieFeeler.Rest.Client;
using MovieFeeler.Rest.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MovieFeeler.Web.Controllers
{
    public class GenreController : Controller
    {
        private IGenreRestApi _genreApi = null;
        public GenreController()
        {
            _genreApi = new GenreRestApi();
        }
        /// <summary>
        /// Get genres list
        /// </summary>
        /// <returns>Genres</returns>
        public ActionResult List()
        {
            var genres = _genreApi.GetGenres();
            return PartialView(genres);
        }
        /// <summary>
        /// Get movies list by genre and page no.
        /// </summary>
        /// <param name="genre"></param>
        /// <param name="page"></param>
        /// <returns>Movies</returns>
        public ActionResult Movies(int id, string name, int? page = 1)
        {
            var movies = _genreApi.GetMoviesByGenreAndPageNo(page.Value, id);
            movies.PageTitle = name;
            movies.genre = id;
            return View(movies);
        }
    }
}
