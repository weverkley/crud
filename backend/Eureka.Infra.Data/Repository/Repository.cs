using Eureka.Domain.Repository;
using Eureka.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eureka.Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;
        private DbSet<T> table = null;

        public Repository(ApplicationContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IQueryable<T> Query()
        {
            return table.AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(Guid id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
