﻿using exercise.wwwapi.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace exercise.wwwapi.Repo
{
    public interface IDatabaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeExpressions);
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Delete(object id);
        void Save();
        DbSet<T> Table { get; }

    }
}
