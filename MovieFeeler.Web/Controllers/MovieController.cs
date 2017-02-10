using MovieFeeler.Rest.Client;
using MovieFeeler.Rest.Client.Interfaces;
using MovieFeeler.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFeeler.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRestApi _movieApi = null;
        public MovieController()
        {
            _movieApi = new MovieRestApi();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>         
        public ActionResult Detail(int id)
        {
            MovieViewModel model = new MovieViewModel();
            model.RecomendedMovies = _movieApi.GetRecomendedMoviesByMovieId(id);
            model.UpComingMovies = _movieApi.GetUpComingMovies();
            model.MovieDTO = _movieApi.GetMovieDetail(id);
            return View(model);
        }
        public ActionResult Upcoming(int? page = 1)
        {
            var upmovies = _movieApi.GetUpComingMovies(page.Value);
            return View(upmovies);
        }
        public ActionResult TopRated(int? page = 1)
        {
            var toprated = _movieApi.GetTopRatedMovies(page.Value);
            return View(toprated);
        }

    }
}
