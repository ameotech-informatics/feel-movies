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
    public class TVController : ApiController
    {
        private readonly ITVRestApi _tvApi = null;
        public TVController()
        {
            _tvApi = new TVRestApi();
        }

        public TvDTO GetLatest()
        {
            var tv=_tvApi.GetLatest();
            return tv;
        }

        public TvsDTO GetPopulor()
        {
            var tvs = _tvApi.GetPopulor();
            return tvs;
        }

        public TvsDTO GetTopRated()
        {
            var tvs = _tvApi.GetTopRated();
            return tvs;
        }

        public TvsDTO GetAiringToday()
        {
            var tvs = _tvApi.GetAiringToday();
            return tvs;
        }


        public TvDTO GetTvDetails(int tvid)
        {
            var tvdetail = _tvApi.GetTvDetails(tvid);
            return tvdetail;
        }

        public TrailerDTO GetTrailers(int tvId)
        {
            var video = _tvApi.GetTrailers(tvId);
            return video;
        }

    }
}
