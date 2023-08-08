using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Eps: BaseEntityGeneric
    {
        public string NombreEps { get; set; }=null!;
        public ICollection<Empleado> EmpleadosAfiliados { get; set; }
        =new List<Empleado>();
        
    }
}