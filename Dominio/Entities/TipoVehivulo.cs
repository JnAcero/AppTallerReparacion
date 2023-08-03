

namespace Dominio.Entities
{
    public class TipoVehivulo:BaseEntityGeneric
    {
        public string Tipo { get; set; } = null!;
        public ICollection<Vehiculo> Vehiculos {get;set;} = new List<Vehiculo>();
       
    }
}