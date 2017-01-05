using CarScheduleCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarScheduleCore.Repository
{
    public class EntityRepository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly DbSet<T> dbset;
        private readonly DbContext _context;
        private readonly bool _lazyLoadingEnabled = true;


        public EntityRepository(DbContext context, bool lazyLoadingEnabledEnabled)
        : this(context)
        {
            _lazyLoadingEnabled = lazyLoadingEnabledEnabled;
        }

        public EntityRepository(DbContext context)
        {
            _context = context;
            _context.Configuration.LazyLoadingEnabled = _lazyLoadingEnabled;
            dbset = context.Set<T>();
        }

        public T Add(T entity)
        {
            dbset.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Update(T entity)
        {
            var originalValues = FindOne(x => x.Id == entity.Id);
            _context.Entry(originalValues).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Remove(int id)
        {
            var entity = dbset.FirstOrDefault(s => s.Id == id);
            if (entity == null) return false;
            dbset.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public List<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return dbset.Where(predicate).ToList();
        }

        public T FindOne(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return dbset.FirstOrDefault(predicate);
        }

        public List<T> FindAll()
        {
            return dbset.ToList();
        }
    }
}
