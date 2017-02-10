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
    public class TrailorController : Controller
    {
        private readonly IMovieRestApi _movieApi = null;
        private readonly ITVRestApi _tvApi = null;
        public TrailorController()
        {
            _movieApi = new MovieRestApi();
            _tvApi = new TVRestApi();
        }
        /// <summary>
        /// Get all tv series lists
        /// </summary>
        /// <returns>TvViewModel</returns>
        public ActionResult Index(int id)
        {
            MovieTrailor model = new MovieTrailor();
            var trailors = _movieApi.GetTrailers(id);
            if (trailors != null && trailors.results.Count > 0)
            {
                model.VideoKey = trailors.results[0].key;
            }
            return View(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult TvTrailer(int id) 
        {
            MovieTrailor model = new MovieTrailor();
            var trailors = _tvApi.GetTrailers(id);
            if (trailors != null && trailors.results.Count > 0)
            {
                model.VideoKey = trailors.results[0].key;
            }
            return View(model);
        }
    }
}
