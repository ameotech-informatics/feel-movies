using MovieFeeler.DTO;
using MovieFeeler.Model;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{
    public class BollyWoodMoviesViewModel
    {
        public BollyWoodMoviesViewModel()
        {
            BollywoodMovies = new List<Movies>();
            UpComingMovies = new List<Movies>();
            LatestMovies = new List<Movies>();
            GetByYear = new List<Movies>();

        }
        public IList<Movies> BollywoodMovies { get; set; }
        public IList<Movies> UpComingMovies { get; set; }
        public IList<Movies> LatestMovies { get; set; }
        public IList<Movies> GetByYear { get; set; }
        public Movies Movie { get; set; }
        public PagedList<Movies> BollywoodMoviesPaged { get; set; }

        public string Year { get; set; }
    }

}

