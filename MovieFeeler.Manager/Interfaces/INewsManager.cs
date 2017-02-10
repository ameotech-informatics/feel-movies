using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Manager.Interfaces
{
    public interface INewsManager
    {
        IList<News> GetNews();

        News Get(int newsId);

        IQueryable<News> GetNewsQueryable();
    }
}
