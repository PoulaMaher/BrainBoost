using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> DbSet;
        private readonly ApplicationDbContext Context;
        public Repository(ApplicationDbContext context)
        {
            this.Context = context;
            this.DbSet = Context.Set<T>();
        }

        void IRepository<T>.add(T entity)
        {
            DbSet.Add(entity);
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> filter, string? includeProps)
        {
            IQueryable<T> query = DbSet;
            if (!string.IsNullOrEmpty(includeProps))
            {
                foreach(var includeProp in includeProps.Split(new char[] { , } , StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        IEnumerable<T> IRepository<T>.GetAll(string? includeProps)
        {
            IQueryable<T> query = DbSet;

            if (!string.IsNullOrEmpty(includeProps))
            {
                foreach (var includeProp in includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        IEnumerable<T> IRepository<T>.GetList(Expression<Func<T, bool>> filter, string? includeProps)
        {
            IQueryable<T> query = DbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProps))
            {
                foreach (var includeProp in includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        void IRepository<T>.remove(T entity)
        {
            DbSet.Remove(entity);
        }

        void IRepository<T>.removeRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }

        void IRepository<T>.save()
        {
            Context.SaveChanges();
        }

        void IRepository<T>.update(T entity)
        {
            DbSet.Update(entity);

        }
    }
}
