using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MovieFeeler.Manager.Interfaces;

using MovieFeeler.Model;
using MovieFeeler.Manager.Impl;

namespace MovieFeeler.WebApi.Controllers
{
    public class BollywoodController : ApiController
    {
        private readonly IBollyWoodMoviesmanager _bollyWoodMgr;
        public BollywoodController()
        {
            _bollyWoodMgr = new BollyWoodMoviesManager();
        }

        public IList<Movies> GetBollyWoodMovies(){
            var movies = _bollyWoodMgr.GetBollyWoodMovies();
            return movies;
        }

        public IList<Movies> GetUpComingMovies()
        {
            var movies = _bollyWoodMgr.GetUpComingMovies();
            return movies;
        }

        public IList<Movies> GetLatestMovies()
        {
            var movies = _bollyWoodMgr.GetLatestMovies();
            return movies;
        }

        public IList<Movies> GetByYear(int year)
        {
            var movies = _bollyWoodMgr.GetByYear(year);
            return movies;
        }

        public IList<Movies> SearchByTitle(string title)
        {
            var movies = _bollyWoodMgr.SearchByTitle(title);
            return movies;
        }

        public Movies GetById(int id)
        {
            return _bollyWoodMgr.GetById(id);
        }

        public IQueryable<Movies> GetBollywoodMoviesQueryable()
        {
            return _bollyWoodMgr.GetBollywoodMoviesQueryable();
        }

    }
}
