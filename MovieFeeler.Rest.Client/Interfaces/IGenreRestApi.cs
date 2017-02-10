using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client.Interfaces
{
    public interface IGenreRestApi
    {
        GenresDTO GetGenres();

        //MoviesDTO GetMoviesByGenre(int genreId);

        MoviesDTO GetMoviesByGenreAndPageNo(int pageno, int genreId);
    }
}
