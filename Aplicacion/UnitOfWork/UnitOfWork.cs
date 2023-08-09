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
        private ClienteRepository _clientes;
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
        public ICliente Clientes{
            get{
                if(_clientes == null)
                {
                    _clientes = new ClienteRepository(_context);
                }
                return _clientes;
            }
        }
        public async Task<int> SaveAsync()
        {
           return  await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}