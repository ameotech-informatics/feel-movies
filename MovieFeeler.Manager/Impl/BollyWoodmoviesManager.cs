using MovieFeeler.DAO;
using MovieFeeler.DAO.Impl;
using MovieFeeler.DAO.Interfaces;
using MovieFeeler.Manager.Interfaces;
using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Manager.Imp
{
    public class BollyWoodMoviesManager : IBollyWoodMoviesmanager
    {
        private IRepository<Movies> _BollywoodMoviesRepo;
        public BollyWoodMoviesManager()
        {
            _BollywoodMoviesRepo = new Repository<Movies>();
        }

        public IList<Movies> GetBollyWoodMovies()
        {
            var movies = _BollywoodMoviesRepo.GetAll(x => !string.IsNullOrEmpty(x.title)
                && x.MovieReleaseDate != DateTime.MinValue)
                .OrderByDescending(x => x.id).ToList();
            return movies;
        }

        public IList<Movies> GetUpComingMovies()
        {
            var movies = _BollywoodMoviesRepo.GetAll(x => !string.IsNullOrEmpty(x.title)
               && x.MovieReleaseDate != DateTime.MinValue);

            movies = movies.Where(x => x.MovieReleaseDate.Date > DateTime.Now.Date)
                .OrderByDescending(x => x.id).ToList();

            return movies;
        }

        public IList<Movies> GetLatestMovies()
        {
            var latestCriteriaDate = DateTime.Now.AddMonths(-2);
            var movies = _BollywoodMoviesRepo.GetAll(x => !string.IsNullOrEmpty(x.title));

            movies = movies.Where(x => x.MovieReleaseDate.Date >= latestCriteriaDate.Date &&
                x.MovieReleaseDate.Date <= DateTime.Now.Date)

                .OrderByDescending(x => x.id).ToList();

            return movies;
        }

        public IList<Movies> GetByYear(int year)
        {
            var movies = _BollywoodMoviesRepo.GetAll(x => !string.IsNullOrEmpty(x.title)
              && !string.IsNullOrEmpty(x.year));

            movies = movies.Where(x => Convert.ToInt32(x.year) == year && x.MovieReleaseDate.Date <= DateTime.Now.Date)
                .OrderByDescending(x => x.id).ToList();

            return movies;
        }

        public IList<Movies> SearchByTitle(string title)
        {
            var movies = _BollywoodMoviesRepo.GetAll(x => !string.IsNullOrEmpty(x.title)
                && x.title.Contains(title));
            return movies;
        }

        public Movies GetById(int id)
        {
            return _BollywoodMoviesRepo.GetById(id);
        }
        public IQueryable<Movies> GetBollywoodMoviesQueryable()
        {
            return _BollywoodMoviesRepo.GetAllQueryable().OrderByDescending(x => x.id);
        }

    }
}
