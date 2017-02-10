using MovieFeeler.DTO;
using MovieFeeler.Model;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{
    public class NewsViewModel
    {
        public NewsViewModel()
        {
            News = new List<News>();
            //NewsPaged = new PagedList<News>();
        }
        public IList<News> News { get; set; }
        public PagedList<News> NewsPaged { get; set; }
        public News Newsdetail { get; set; }
          
    }
 
}

