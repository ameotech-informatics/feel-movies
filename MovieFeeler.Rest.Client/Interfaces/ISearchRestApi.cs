using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client.Interfaces
{
    public interface ISearchRestApi
    {
        SearchDTO MultiSearch(string query, int page);
        object SearchCompanies();
        object SearchCollections();
        object SearchMovies();
        object SearchTvShows();

    }
}
