﻿using Microsoft.EntityFrameworkCore;
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

       public void add(T entity)
        {
            DbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProps)
        {
            IQueryable<T> query = DbSet;
            if (!string.IsNullOrEmpty(includeProps))
            {
                foreach(var includeProp in includeProps.Split(new char[] { ',' } , StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProps)
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

        public IEnumerable<T> GetList(Expression<Func<T, bool>> filter, string? includeProps)
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

       public void remove(T entity)
        {
            DbSet.Remove(entity);
        }

       public  void removeRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }

       

         public void update(T entity)
        {
            DbSet.Update(entity);

        }
    }
}
