using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.DAO.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        IList<T> GetAll();
        
        T GetById(int id);
        
        bool IsExist(Expression<Func<T, bool>> exp);

        IQueryable<T> GetAllQueryable();

        IList<T> GetAll(Expression<Func<T, bool>> exp);
    }
}
