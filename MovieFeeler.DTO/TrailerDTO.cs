using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DTO
{

    public class TrailerDTO
    {
        public TrailerDTO()
        {
            results = new List<Trailer>();
        }
        public int id { get; set; }
        public IList<Trailer> results { get; set; }
    }
    public class Trailer
    {
        public string id { get; set; }
        public string iso_639_1 { get; set; }
        public string iso_3166_1 { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string site { get; set; }
        public int size { get; set; }
        public string type { get; set; }
    }
}
