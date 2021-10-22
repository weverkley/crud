using System;
using System.Collections.Generic;
using System.Linq;

namespace Eureka.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Query();
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Guid id);
        void Save();
    }
}
