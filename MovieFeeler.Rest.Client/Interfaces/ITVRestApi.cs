using MovieFeeler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client.Interfaces
{
    public interface ITVRestApi
    {
        TvDTO GetLatest();

        TvsDTO GetPopulor();

        TvsDTO GetTopRated();

        TvsDTO GetAiringToday();

        TvDTO GetTvDetails(int tvid);

        TrailerDTO GetTrailers(int tvId);
    }
}
