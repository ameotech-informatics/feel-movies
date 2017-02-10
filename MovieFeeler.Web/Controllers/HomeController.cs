using MovieFeeler.Common;
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
    public class HomeController : Controller
    {
        private readonly IMovieRestApi _movieApi = null;
        public HomeController()
        {
            _movieApi = new MovieRestApi();
        }
        public ActionResult Index()
        {            
            HomeViewModel model = new HomeViewModel();
            model.PopularMovies = _movieApi.GetPopularMovies();                       
            model.TopRatedMovies = _movieApi.GetTopRatedMovies();
            model.UpcomingMovies = _movieApi.GetUpComingMovies();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult NotFound() 
        {
            ViewBag.Message = "Not found page.";

            return View();
        }
    }
}
