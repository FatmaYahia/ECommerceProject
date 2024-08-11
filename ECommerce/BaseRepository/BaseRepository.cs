using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext DB;
        public BaseRepository(DataContext db) { 
        DB = db;
        }
        public bool Any()
        {
            return DB.Set<T>().Any();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return DB.Set<T>().Any(expression);
        }

        public T CreateEntity(T entity)
        {
            EntityEntry<T> entry=DB.Set<T>().Add(entity);
            return entry.Entity;
        }

        public void DeleteEntity(T entity)
        {
            DB.Set<T>().Remove(entity);
        }

        public void DeleteEntity(List<T> entities)
        {
            DB.Set<T>().RemoveRange(entities);
        }

        public List<T> GetAll()
        {
            return DB.Set<T>().ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return DB.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            return DB.Set<T>().Find(id);
        }

        public int Save()
        {
            return DB.SaveChanges();
        }

        public void UpdateEntity(T entity)
        {
            DB.Entry(entity).State = EntityState.Modified;

        }
    }
}
