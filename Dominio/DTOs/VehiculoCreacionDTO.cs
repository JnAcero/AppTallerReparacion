using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class VehiculoCreacionDTO
    {
         public string Placa { get; set; } = null!;
        public string Marca { get; set; }= null!;
        public string ? Modelo { get; set; }
        public double Kilometraje { get; set; }
        public int ClienteId { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}