using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{
    public class TvViewModel
    {
        public TvViewModel()
        {
            GetLatest = new TvDTO();
            GetPopulor = new TvsDTO();
            GetTopRated = new TvsDTO();
            GetAiringToday = new TvsDTO();
            
        }
        public TvDTO GetLatest { get; set; }
        public TvsDTO GetPopulor { get; set; }
        public TvsDTO GetTopRated { get; set; }
        public TvsDTO GetAiringToday { get; set; }      
    }

    public class TvDetailViewModel    
    {
        public TvDetailViewModel() 
        {
            GetTvDetails = new TvDTO();
            GetAiringToday = new TvsDTO();
        }
        public TvDTO GetTvDetails { get; set; }
        public TvsDTO GetAiringToday { get; set; }      
     }
}

