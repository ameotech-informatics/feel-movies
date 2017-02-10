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
    public class TVController : Controller
    {
        private readonly ITVRestApi _tvApi = null;
        public TVController()
        {
            _tvApi = new TVRestApi();
        }
        /// <summary>
        /// Get all tv series lists
        /// </summary>
        /// <returns>TvViewModel</returns>
        public ActionResult Index()
        {
            TvViewModel model = new TvViewModel();
            model.GetLatest = _tvApi.GetLatest();
            model.GetPopulor = _tvApi.GetPopulor();
            model.GetTopRated = _tvApi.GetTopRated();
            model.GetAiringToday = _tvApi.GetAiringToday();

            return View(model);
        }
        public ActionResult Detail(int id)
        {
            TvDetailViewModel model = new TvDetailViewModel();
            model.GetAiringToday = _tvApi.GetAiringToday();
            model.GetTvDetails = _tvApi.GetTvDetails(id);
            return View(model);
        }

    }
}
