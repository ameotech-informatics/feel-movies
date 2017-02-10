using MovieFeeler.DAO.Interfaces;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Linq.Expressions;
using NHibernate.Linq;
using FluentNHibernate.Cfg;
using System.Configuration;
using MovieFeeler.Model;


namespace MovieFeeler.DAO.Impl
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private MFContext _mfContext = new MFContext();
        public void Add(T entity)
        {
            _mfContext.Set<T>().Add(entity);
            _mfContext.SaveChanges();
        }

        public void Update(T entity)
        {
            //_mfContext.Set<T>().Add(entity);
            _mfContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            _mfContext.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return _mfContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _mfContext.Set<T>().FirstOrDefault(x => x.id == id);
        }

        public bool IsExist(Expression<Func<T, bool>> exp)
        {
            return _mfContext.Set<T>().Count(exp) > 0;
        }

        public IQueryable<T> GetAllQueryable()
        {
            return _mfContext.Set<T>().AsQueryable();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> exp)
        {
            return _mfContext.Set<T>().ToList();
        }
    }
}
