
namespace Dominio.Entities
{
    public class Cliente:BaseEntityPersona
    {
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } =null!;  
        public virtual ICollection<Vehiculo> Vehiculos {get;set;} = new List<Vehiculo>();
    }
}