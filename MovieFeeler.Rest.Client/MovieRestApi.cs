using MovieFeeler.Common;
using MovieFeeler.DTO;
using MovieFeeler.Rest.Client.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client
{
    public class MovieRestApi : MovieDBBaseApi, IMovieRestApi
    {
        private readonly CacheHelper _cacheHelper;
        public MovieRestApi()
            : base(ConfigSettings.GetApiKey(), ConfigSettings.GetMovieDBUrl())
        {
            _cacheHelper = new CacheHelper(new CacheItemPolicy() { AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddDays(5)) });
        }

        /// <summary>
        /// Get Latest movies from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MovieDTO GetLatestMovies()
        {
            var movies = (MovieDTO)_cacheHelper.Get("LATEST_MOVIES");
            if (movies == null)
            {
                var request = new RestRequest("movie/latest");
                movies = base.ExecuteRequest<MovieDTO>(request);
                _cacheHelper.Add("LATEST_MOVIES", movies);
            }
            return movies;
        }

        /// <summary>
        /// Get Popular movies from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MoviesDTO GetPopularMovies()
        {
            var movies = (MoviesDTO)_cacheHelper.Get("POPULAR_MOVIES");
            if (movies == null)
            {
                var request = new RestRequest("movie/popular");
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add("POPULAR_MOVIES", movies);
            }
            return movies;
        }

        /// <summary>
        /// Get Top Rated movies from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MoviesDTO GetTopRatedMovies(int? page = 1)
        {
            var movies = (MoviesDTO)_cacheHelper.Get(string.Format("TOPRATED_MOVIES_PAGE_{0}", page));
            if (movies == null)
            {
                var request = new RestRequest("movie/top_rated");
                request.AddParameter("page", page);
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add(string.Format("TOPRATED_MOVIES_PAGE_{0}", page), movies);
            }
            return movies;
        }

        /// <summary>
        /// Get Upcoming movies from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MoviesDTO GetUpComingMovies(int? page = 1)
        {
            var movies = (MoviesDTO)_cacheHelper.Get(string.Format("UPCOMING_MOVIES_PAGE_{0}", page));
            if (movies == null)
            {
                var request = new RestRequest("movie/upcoming");
                request.AddParameter("page", page);
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add(string.Format("UPCOMING_MOVIES_PAGE_{0}", page), movies);
            }
            return movies;
        }

        /// <summary>
        /// Get recommended movies list from themoviedb API
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns>Movies</returns>
        public MoviesDTO GetRecomendedMoviesByMovieId(int movieId)
        {
            var movies = (MoviesDTO)_cacheHelper.Get(string.Format("RECOMENDED_MOVIES_{0}",movieId));
            if (movies == null)
            {
                var request = new RestRequest(string.Format("movie/{0}/recommendations", movieId));
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add("RECOMENDED_MOVIES_{0}", movies);
            }
            return movies;
        }

        /// <summary>
        /// Get NowPlaying movies from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MoviesDTO GetNowPlayingMovies()
        {
            var movies = (MoviesDTO)_cacheHelper.Get("NOWPLAYING_MOVIES");
            if (movies == null)
            {
                var request = new RestRequest("movie/now_playing");
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add("NOWPLAYING_MOVIES", movies);
            }
            return movies;
        }

        /// <summary>
        /// Get movie detail by movie id from themoviedb API
        /// </summary>
        /// <returns>Movies</returns>
        public MovieDTO GetMovieDetail(int movieId)
        {
            var movie = (MovieDTO)_cacheHelper.Get(string.Format("MOVIE_DETAIL_{0}", movieId));
            if (movie == null)
            {
                var request = new RestRequest(string.Format("movie/{0}", movieId));
                movie = base.ExecuteRequest<MovieDTO>(request);
                _cacheHelper.Add(string.Format("MOVIE_DETAIL_{0}", movieId), movie);
            }
            return movie;
        }

        /// <summary>
        /// Get movie trailer detail by movie id from themoviedb API.
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns>Trailer Detail</returns>
        public TrailerDTO GetTrailers(int movieId)
        {
            var video = (TrailerDTO)_cacheHelper.Get(string.Format("MOVIE_TRAILER_{0}",movieId));
            if (video == null)
            {
                var request = new RestRequest(string.Format("movie/{0}/videos", movieId));
                video = base.ExecuteRequest<TrailerDTO>(request);
                _cacheHelper.Add(string.Format("MOVIE_TRAILER_{0}", movieId), video);
            }
            return video;
        }
    }
}
