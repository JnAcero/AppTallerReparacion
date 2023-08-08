using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Arl:BaseEntityGeneric
    {
        public string NombreArl {get; set;}
        public ICollection<Empleado> EmpleadosAfiliados {get; set;} = new List<Empleado>();

    }
}