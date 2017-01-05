using CarScheduleCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CarScheduleCore.Repository
{
    public interface IRepository<T> where T : class,IEntity
    {
        T Add(T entity);
        bool Update(T entity);
        bool Remove(int id);
        T FindOne(Expression<Func<T, bool>> predicate);
        List<T> Find(Expression<Func<T, bool>> predicate);
        List<T> FindAll();
    }
}
