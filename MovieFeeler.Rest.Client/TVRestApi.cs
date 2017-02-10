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
    public class TVRestApi:MovieDBBaseApi,ITVRestApi
    {
        private readonly CacheHelper _cacheHelper;
        
        public TVRestApi() :
            base(ConfigSettings.GetApiKey(), ConfigSettings.GetMovieDBUrl()) 
        {
            _cacheHelper = new CacheHelper(new CacheItemPolicy() { AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddDays(5)) });
        }

        /// <summary>
        /// Get Latest tv from themoviedb API
        /// </summary>
        /// <returns>Tv</returns>
        public TvDTO GetLatest()
        {
            var tv = (TvDTO)_cacheHelper.Get("LATEST_TV");
            if (tv == null)
            {
                var request = new RestRequest("tv/latest");
                tv = base.ExecuteRequest<TvDTO>(request);
                _cacheHelper.Add("LATEST_TV", tv);
            }
            return tv;
        }

        /// <summary>
        /// Get Popular tv from themoviedb API
        /// </summary>
        /// <returns>Tv Series</returns>
        public TvsDTO GetPopulor()
        {
            var tvs = (TvsDTO)_cacheHelper.Get("POPULAR_TV");
            if (tvs == null)
            {
                var request = new RestRequest("tv/popular");
                tvs = base.ExecuteRequest<TvsDTO>(request);
                _cacheHelper.Add("POPULAR_TV", tvs);
            }
            return tvs;
        }

        /// <summary>
        /// Get Top Rated tv from themoviedb API
        /// </summary>
        /// <returns>TvSeries</returns>
        public TvsDTO GetTopRated()
        {
            var tvs = (TvsDTO)_cacheHelper.Get("TOPRATED_TV");
            if (tvs == null)
            {
                var request = new RestRequest("tv/top_rated");
                tvs = base.ExecuteRequest<TvsDTO>(request);
                _cacheHelper.Add("TOPRATED_TV", tvs);
            }
            return tvs;
        }
        /// <summary>
        /// Get Airing today from themoviedb API
        /// </summary>
        /// <returns>Tv Series</returns>
        public TvsDTO GetAiringToday()
        {
            var tvs = (TvsDTO)_cacheHelper.Get("AIRING_TODAY");
            if (tvs == null)
            {
                var request = new RestRequest("tv/airing_today");
                tvs = base.ExecuteRequest<TvsDTO>(request);
                _cacheHelper.Add("AIRING_TODAY", tvs);
            }
            return tvs;
        }
        /// <summary>
        /// Get tv detail by tv id from themoviedb API.
        /// </summary>
        /// <param name="tvid"></param>
        /// <returns>Tv</returns>
        public TvDTO GetTvDetails(int tvid) 
        {
            var request = new RestRequest(string.Format("tv/{0}", tvid));
            var tvdetail = base.ExecuteRequest<TvDTO>(request);
            return tvdetail;
        }
        /// <summary>
        /// Get trailer by tv id from themoviedb API.
        /// </summary>
        /// <param name="tvId"></param>
        /// <returns>Trailer detail</returns>
        public TrailerDTO GetTrailers(int tvId)
        {
            var video = (TrailerDTO)_cacheHelper.Get(string.Format("TV_TRAILER_{0}", tvId));
            if (video == null)
            {
                var request = new RestRequest(string.Format("tv/{0}/videos", tvId));
                video = base.ExecuteRequest<TrailerDTO>(request);
                _cacheHelper.Add(string.Format("TV_TRAILER_{0}", tvId), video);
            }
            return video;
        }
    }

}
