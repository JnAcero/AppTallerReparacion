using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repositorios
{
    public class GenericRepoPersona<T>:IGenericPersona<T> where T:BaseEntityPersona
    {
        private readonly TallerRepDbContext _context;
        public GenericRepoPersona(TallerRepDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public virtual IEnumerable<T> Find(Predicate<T> predicado)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
        
    }
}