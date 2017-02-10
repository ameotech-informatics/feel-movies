using MovieFeeler.Common;
using MovieFeeler.DTO;
using MovieFeeler.Rest.Client.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client
{
    public class SearchRestApi : MovieDBBaseApi, ISearchRestApi
    {
        private readonly CacheHelper _cacheHelper;
        public SearchRestApi()
            : base(ConfigSettings.GetApiKey(), ConfigSettings.GetMovieDBUrl())
        {
            _cacheHelper = new CacheHelper(new CacheItemPolicy() { AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddDays(5)) });
        }

        public SearchDTO MultiSearch(string query, int page)
        {
            var request = new RestRequest("search/multi");
            request.AddParameter("query", query);
            request.AddParameter("page",page);
            var searchdata = base.ExecuteRequest<SearchDTO>(request);
            return searchdata;
        }
        public object SearchCompanies()
        {
            throw new NotImplementedException();
        }

        public object SearchCollections()
        {
            throw new NotImplementedException();
        }

        public object SearchMovies()
        {
            throw new NotImplementedException();
        }

        public object SearchTvShows()
        {
            throw new NotImplementedException();
        }
    }
}
