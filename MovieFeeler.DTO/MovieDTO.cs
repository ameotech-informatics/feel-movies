using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DTO
{
    public class MoviesDTO
    {
        public MoviesDTO()
        {
            results = new List<MovieDTO>();
        }
        public string PageTitle { get; set; }
        public int page { get; set; }
        public int genre { get; set; }
        public IList<MovieDTO> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }

    }

    public class BelongsToCollection
    {

        public int id { get; set; }
        public string name { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }        
    }

    public class MovieDTO
    {
        private string _imagePath = "https://image.tmdb.org/t/p/w500/";
        private string _posterPath = "https://image.tmdb.org/t/p/w500/";
        public MovieDTO()
        {
            genres = new List<GenresDTO>();
            production_companies = new List<ProductionCompany>();
            production_countries = new List<ProductionCountry>();
            spoken_languages = new List<SpokenLanguage>();
            genre_ids = new List<int>();
            this.belongs_to_collection = new BelongsToCollection();
        }

        public string short_title
        {
            get
            {
                if (this.title.Length > 15)
                    return this.title.Substring(0, 15) + "...";

                return this.title;
            }
        }

        public string short_overview
        {
            get
            {
                if (this.overview.Length > 180)
                    return this.overview.Substring(0, 180) + "...";

                return this.overview;
            }
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
                if (value == null || value == string.Empty)
                    _imagePath = "/Images/default_poster_index.jpg";
                else
                    _imagePath = _imagePath + value;
            }
        }
        public BelongsToCollection belongs_to_collection { get; set; }
        public long budget { get; set; }
        public IList<GenresDTO> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string popularity { get; set; }

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
        public IList<ProductionCountry> production_countries { get; set; }
        public string release_date { get; set; }
        public long revenue { get; set; }
        public string runtime { get; set; }
        public IList<SpokenLanguage> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public IList<int> genre_ids { get; set; }

    }
    public class ProductionCompany
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class ProductionCountry
    {
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
    }
    public class SpokenLanguage
    {
        public string iso_639_1 { get; set; }
        public string name { get; set; }
    }
    
}
