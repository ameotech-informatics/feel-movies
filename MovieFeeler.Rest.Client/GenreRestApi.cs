using MovieFeeler.Common;
using MovieFeeler.DTO;
using MovieFeeler.Rest.Client.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
namespace MovieFeeler.Rest.Client
{
    public class GenreRestApi : MovieDBBaseApi, IGenreRestApi
    {
        private readonly CacheHelper _cacheHelper;

        public GenreRestApi()
            : base(ConfigSettings.GetApiKey(), ConfigSettings.GetMovieDBUrl())
        {
            _cacheHelper = new CacheHelper(new CacheItemPolicy() { AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddMonths(1)) });
        }

        //public MoviesDTO GetMoviesByGenre(int genreId)
        //{
        //    string cacheKey = string.Format("GENRE_MOVIE_CACHE_KEY_{0}", genreId);
        //    var movies = (MoviesDTO)_cacheHelper.Get(cacheKey);
        //    if (movies == null)
        //    {
        //        var request = new RestRequest(string.Format("/genre/{0}/movies", genreId));
        //        movies = base.ExecuteRequest<MoviesDTO>(request);
        //        _cacheHelper.Add(new CacheItem(cacheKey, movies));
        //    }
        //    return movies;
        //}

        public GenresDTO GetGenres()
        {
            var genres = (GenresDTO)_cacheHelper.Get("GENRE_CACHE_KEY");
            if (genres == null)
            {
                var request = new RestRequest("genre/movie/list");
                genres = base.ExecuteRequest<GenresDTO>(request);
                _cacheHelper.Add(new CacheItem("GENRE_CACHE_KEY", genres));
            }
            return genres;
        }

        /// <summary>
        /// Get movie list by page no and genres id from themoviedb API
        /// </summary>
        /// <param name="pageno"></param>
        /// <param name="genreId"></param>
        /// <returns></returns>
        public MoviesDTO GetMoviesByGenreAndPageNo(int pageno, int genreId)
        {
            string cacheKey = string.Format("GENRE_MOVIE_CACHE_KEY_GENRE_{0}_PAGE_{1}", genreId, pageno);
            var movies = (MoviesDTO)_cacheHelper.Get(cacheKey);
            if (movies == null)
            {
                var request = new RestRequest("discover/movie");
                request.AddParameter("page", pageno);
                request.AddParameter("with_genres", genreId);
                movies = base.ExecuteRequest<MoviesDTO>(request);
                _cacheHelper.Add(new CacheItem(cacheKey, movies));
            }
            return movies;
        }
    }
}
