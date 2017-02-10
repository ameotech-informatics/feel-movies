using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DTO
{
    public class TvsDTO 
    {
        public TvsDTO() 
        {
            results = new List<TvDTO>();
        }
        public int page { get; set; }
        public IList<TvDTO> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
    public class TvDTO
    {
        private string _imagePath = "https://image.tmdb.org/t/p/w500/";
        private string _posterPath = "https://image.tmdb.org/t/p/w500/";
        public TvDTO() 
        {
           // created_by = new List<string>();
            episode_run_time = new List<int>();
            genres = new List<GenreDTO>();
            genre_ids = new List<int>();
            languages = new List<string>();
          //  networks = new List<string>();
            origin_country = new List<string>();
            production_companies=new List<ProductionCompany>();
            seasons = new List<Season>();
        }
        public string backdrop_path
        {
            get
            {
                return _imagePath;
            }
            set
            {
                if (value == null || value == string.Empty)
                    _imagePath = "/Images/default_poster_index.jpg";
                else
                    _imagePath = _imagePath + value;
            }
        }
       // public IList<string> created_by { get; set; }
        public IList<int> episode_run_time { get; set; }
        public string first_air_date { get; set; }
        public IList<GenreDTO> genres { get; set; }
        public IList<int> genre_ids { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public bool in_production { get; set; }
        public IList<string>  languages { get; set; }
        public string last_air_date { get; set; }
        public string name { get; set; }
        public string short_name
        {
            get
            {
                if (this.name.Length > 15)
                    return this.name.Substring(0, 15) + "...";

                return this.name;
            }
        }
       // public IList<string> networks { get; set; }
        public string number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public IList<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public string short_overview
        {
            get
            {
                if (this.overview.Length > 180)
                    return this.overview.Substring(0, 180) + "...";

                return this.overview;
            }
        }
        public long popularity { get; set; }

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
        public IList<ProductionCompany> production_companies { get; set; }
        public IList<Season> seasons { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
    }

    public class Season
    {
        public string air_date { get; set; } 
        public int episode_count { get; set; }
        public int id { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }
    }
    public class Network 
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}