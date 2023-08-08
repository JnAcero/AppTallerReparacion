using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repositorios
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehivulo
    {
        private readonly IMapper _mapper;

        public VehiculoRepository(TallerRepDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
    }
}