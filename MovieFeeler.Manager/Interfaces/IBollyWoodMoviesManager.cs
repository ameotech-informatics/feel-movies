using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Manager.Interfaces
{
   public interface IBollyWoodMoviesmanager
    {
       IList<Movies> GetBollyWoodMovies();

       IList<Movies> GetUpComingMovies();

       IList<Movies> GetLatestMovies();

       IList<Movies> GetByYear(int year);

       IList<Movies> SearchByTitle(string title);

       Movies GetById(int id);

       IQueryable<Movies> GetBollywoodMoviesQueryable();
    }
}
