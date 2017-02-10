using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Web.Models
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            this.SearchedResult = new List<SearchModelDTO>();
        }
        public string q { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public IList<SearchModelDTO> SearchedResult { get; set; }
    }
}