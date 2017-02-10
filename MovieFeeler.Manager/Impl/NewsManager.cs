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
    public class NewsManager : INewsManager
    {
        private IRepository<News> _newsRepo;
        public NewsManager()
        {
            _newsRepo = new Repository<News>();
        }

        public IList<News> GetNews()
        {
            return _newsRepo.GetAll().OrderByDescending(x => x.id).ToList();
        }

        public IQueryable<News> GetNewsQueryable()
        {
            return _newsRepo.GetAllQueryable().OrderByDescending(x => x.id);
        }

        public News Get(int newsId)
        {
            return _newsRepo.GetById(newsId);
        }
    }
}
