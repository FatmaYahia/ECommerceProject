using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepository
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T GetById(int id);
        bool Any();
        bool Any(Expression<Func<T, bool>> expression);
        public T CreateEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteEntity(List<T> entities);
        int Save();
    }
}
