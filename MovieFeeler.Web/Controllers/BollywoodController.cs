using MovieFeeler.Manager.Imp;
using MovieFeeler.Manager.Interfaces;
using MovieFeeler.Model;
using MovieFeeler.Rest.Client;
using MovieFeeler.Rest.Client.Interfaces;
using MovieFeeler.Web.Models;
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
    public class BollywoodController : Controller
    {
        private readonly IBollyWoodMoviesmanager _bollyWoodMgr;
        public BollywoodController()
        {
            _bollyWoodMgr = new BollyWoodMoviesManager();
        }

        public ActionResult Index()
        {
            BollyWoodMoviesViewModel model = new BollyWoodMoviesViewModel();
            model.BollywoodMovies = _bollyWoodMgr.GetBollyWoodMovies();
            model.UpComingMovies = _bollyWoodMgr.GetUpComingMovies();
            model.LatestMovies = _bollyWoodMgr.GetLatestMovies();
            model.GetByYear = _bollyWoodMgr.GetByYear(DateTime.Now.Year);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            BollyWoodMoviesViewModel model = new BollyWoodMoviesViewModel();
            model.Movie = _bollyWoodMgr.GetById(id);
            model.UpComingMovies = _bollyWoodMgr.GetUpComingMovies()
                .Where(x => x.id != model.Movie.id).ToList();

            return View(model);
        }

        public ActionResult Movies(string year,int? page = 1)
        {
            BollyWoodMoviesViewModel model = new BollyWoodMoviesViewModel();
            model.Year = year;            
            model.BollywoodMoviesPaged = new MvcPaging.PagedList<Movies>(_bollyWoodMgr.GetByYear(Convert.ToInt32(year)), page.Value, 20);  
            return View("MoviesByYear", model);           
        }
    }
}
