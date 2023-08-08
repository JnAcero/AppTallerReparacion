using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Profesion:BaseEntityGeneric
    {
        public string ? Carrera { get; set; }
        public string ? Universidad { get; set; }
        public ICollection<ProfesionEmpleado> ProfesionesEmpleados { get; set; }
        =new List<ProfesionEmpleado>();
        
    }
}