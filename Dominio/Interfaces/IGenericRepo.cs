
using System;
using Dominio.Entities;

namespace Dominio.Interfaces
{
    public interface IGenericRepo<T> where T:BaseEntityGeneric
    {
        Task<T>GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Predicate<T> predicado);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void Update(T entity);
   
    }
}