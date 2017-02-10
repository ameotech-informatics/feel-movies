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

    public class SearchController : Controller
    {
        private readonly ISearchRestApi _searchApi = null;
        public SearchController()
        {
            _searchApi = new SearchRestApi();
        }

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Get search result by query from themoviedb API.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        public ActionResult Search(string q, int? page = 1)
        {
            SearchViewModel model = new SearchViewModel();
            var data = _searchApi.MultiSearch(q, page.Value);
            model.q = q;
            model.page = data.page;
            model.total_results = data.total_results;
            model.SearchedResult= data.results.Where(x => x.media_type == "tv" || x.media_type == "movie").ToList();
            return View(model);
        }
    }
}
