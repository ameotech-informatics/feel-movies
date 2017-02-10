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
    public class SearchController : ApiController
    {
        private readonly ISearchRestApi _searchApi = null;
        public SearchController()
        {
            _searchApi = new SearchRestApi();
        }

        [HttpGet]
        public SearchDTO MultiSearch(string query, int page)
        {
            var searchdata = _searchApi.MultiSearch(query,page);
            return searchdata;
        }

        [HttpGet]
        public object SearchCompanies()
        {
            var searchdata = _searchApi.SearchCompanies();
            return searchdata;
        }

        [HttpGet]
        public object SearchCollections()
        {
            var searchdata = _searchApi.SearchCollections();
            return searchdata;
        }

        [HttpGet]
        public object SearchMovies()
        {
            var searchdata = _searchApi.SearchMovies();
            return searchdata;
        }

        [HttpGet]
        public object SearchTvShows()
        {
            var searchdata = _searchApi.SearchTvShows();
            return searchdata;
        }
    }
}
