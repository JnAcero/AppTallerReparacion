using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repositorios;
using Dominio.Interfaces;
using Persistencia;
using AutoMapper;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TallerRepDbContext _context;
        private readonly IMapper _mapper;
        private VehiculoRepository _vehiculos;
        public UnitOfWork(TallerRepDbContext context)
        {
            _context = context;
        }

        public IVehivulo Vehiculos{
            get{
                if(_vehiculos == null)
                {
                    _vehiculos =new VehiculoRepository(_context,_mapper);
                }
                return _vehiculos;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}