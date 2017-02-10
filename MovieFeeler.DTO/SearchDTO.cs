using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DTO
{
    public class SearchDTO
    {
        public SearchDTO()
        {
            results = new List<SearchModelDTO>();
        }
        public string q { get; set; }
        public int page { get; set; }
        public IList<SearchModelDTO> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }

    public class SearchModelDTO : SearchMediaDTO
    {
        public SearchModelDTO()
        {
            known_for = new List<SearchMediaDTO>();
        }
        public IList<SearchMediaDTO> known_for { get; set; }
        public string profile_path { get; set; }
    }

    public class SearchMediaDTO
    {
        private string _imagePath = "https://image.tmdb.org/t/p/w500/";
        private string _posterPath = "https://image.tmdb.org/t/p/w500/";
        public SearchMediaDTO()
        {
            genre_ids = new List<int>();
            origin_country = new List<string>();
        }
        public bool adult { get; set; }
        public string backdrop_path
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = _imagePath + value;
            }
        }
        public string first_air_date { get; set; }
        public IList<int> genre_ids { get; set; }
        public int id { get; set; }
        public string media_type { get; set; }
        public string name { get; set; }
        public string short_name
        {
            get
            {

                if (!string.IsNullOrEmpty(this.name) && this.name.Length > 15)
                    return this.name.Substring(0, 15) + "...";

                return this.name;
            }
        }
        public IList<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string poster_path
        {
            get
            {
                return _posterPath;
            }
            set
            {
                if (value == null || value == string.Empty)
                    _posterPath = "/Images/default_poster.jpg";
                else
                    _posterPath = _posterPath + value;
            }
        }
        public long popularity { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public string short_title
        {
            get
            {

                if (!string.IsNullOrEmpty(this.title) && this.title.Length > 15)
                    return this.title.Substring(0, 15) + "...";

                return this.title;
            }
        }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
    }
}