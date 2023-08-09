using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        IVehivulo Vehiculos {get;}
        ICliente Clientes {get;}
        Task<int> SaveAsync();
    }
}