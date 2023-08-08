using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Contacto:BaseEntityGeneric
    {
        public string ? Nombre  { get; set; }
        public string  ? Telefono { get; set; }
        public string ? Parentesco {  get; set; }
        public ICollection<ContactoEmpleado> ContactosEmpleados { get; set; }
        = new List<ContactoEmpleado>();
        
    }
}