using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client.Interfaces
{
    public interface IMovieRestApi
    {
        MovieDTO GetLatestMovies();

        MoviesDTO GetPopularMovies();

        MoviesDTO GetTopRatedMovies(int? page = 1);

        MoviesDTO GetUpComingMovies(int? page = 1);

        MoviesDTO GetNowPlayingMovies();

        MoviesDTO GetRecomendedMoviesByMovieId(int movieId);

        MovieDTO GetMovieDetail(int movieId);

        TrailerDTO GetTrailers(int movieId);
    }
}
