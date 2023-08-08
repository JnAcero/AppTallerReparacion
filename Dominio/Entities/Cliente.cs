
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Cliente:BaseEntityPersona
    {
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } =null!;  
        public virtual ICollection<Vehiculo> Vehiculos {get;set;} = new List<Vehiculo>();
        public ICollection<ClienteSucursal> ClientesSucursales {get;set;}
        =new List<ClienteSucursal>();
    }
}