using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class TipoUsuario:BaseEntityGeneric
    {
       public string Tipo { get; set; } = null!;
       public string ? Permisos { get; set; }
       public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}