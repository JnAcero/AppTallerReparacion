using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTOs;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/controler/vehiculo")]
    public class VehiculoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VehiculoController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> PostVehiculo(VehiculoCreacionDTO vehiculoDto)
        {
            var vehiculo = _mapper.Map<Vehiculo>(vehiculoDto);
            _unitOfWork.Vehiculos.Add(vehiculo);
            await _unitOfWork.SaveAsync();
            return Ok();
        }
    }
}