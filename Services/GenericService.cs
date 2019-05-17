using Repository;
using System;
using System.Collections.Generic;

namespace Services
{
    public class GenericService<T> : IDisposable,IGenericService<T> where T : class
    {
        public IRepository<T> Repository { get; internal set; }
        public IUnitOfWork UnitOfWork { get; internal set; }

        public void Add(T entity)
        {
            Repository.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Repository.AddRange(entities);
        }


        public T Get(int id)
        {
            return Repository.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Repository.GetAll();
        }

        public void Remove(T entity)
        {
            Repository.Remove(entity);
        }
        public void Dispose()
        {
            
            
        }
    }
}
