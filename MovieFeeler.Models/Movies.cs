using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieFeeler.Model
{
    [Table("movies_latest")]
    public class Movies : BaseModel
    {
        public string overview { get; set; }
        public string Cinematography { get; set; }
        public string Musicby { get; set; }
        public string title { get; set; }
        public string Releasedates { get; set; }
        public string Producedby { get; set; }
        public string Starring { get; set; }
        public string Country { get; set; }
        public string Distributedby { get; set; }
        public string Language { get; set; }
        public string poster { get; set; }
        public string director { get; set; }
        public string link { get; set; }
        public string genre { get; set; }
        public string Screenplayby { get; set; }
        public string Productioncompany { get; set; }
        public string release_date { get; set; }
        public string Editedby { get; set; }
        public string Directedby { get; set; }
        public string cast { get; set; }
        public string movietitle { get; set; }
        public string year { get; set; }
        public string trailerurl { get; set; }

        public DateTime MovieReleaseDate
        {
            get
            {
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(release_date))
                {
                    string date = string.Format("{0} {1}", release_date, year);
                    return DateTime.Parse(date);
                }
                return DateTime.MinValue;
            }
        }

        public string ReleasedOn
        {
            get
            {
                if (this.MovieReleaseDate.Date > DateTime.Now.Date)
                    return string.Format("In Theaters By {0}", this.MovieReleaseDate.Date.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));

                return string.Format("Released On {0}", this.MovieReleaseDate.Date.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            }
        }



        //public string movietitle { get; set; }
        //public string short_movietitle
        //{
        //    get
        //    {
        //        if (this.movietitle.Length > 15)
        //            return this.movietitle.Substring(0, 15) + "...";

        //        return this.movietitle;
        //    }
        //}

        //public string movietime  { get; set; }
        //public string moviegenre { get; set; }
        //public string movieimage { get; set; }
        //public string country { get; set; }
        //public string boxoffice  { get; set; }
        //public string censorrating { get; set; }
        //public string releasedate { get; set; }
        //public string director { get; set; }
        //public string actors  { get; set; }
        //public string budget { get; set; }
        //public string boxofficecollection { get; set; }


    }


}

