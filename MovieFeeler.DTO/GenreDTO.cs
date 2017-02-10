using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DTO
{
    public class GenresDTO
    {
        public GenresDTO()
        {
            genres = new List<GenreDTO>();
        }
        public List<GenreDTO> genres { get; set; }
    }

    public class GenreDTO
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
