
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Vehiculo:BaseEntityGeneric
    {
        public string Placa { get; set; } = null!;
        public string Marca { get; set; }= null!;
        public string ? Modelo { get; set; }
        public double Kilometraje { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }= null!;
        public int TipoVehiculoId { get; set; }
        [ForeignKey("TipoVehiculoId")]
        public virtual TipoVehivulo TipoVehivulo { get; set; }= null!; 
        public ICollection<OrdenReparacion> OrdenesReparacion { get; set; }= new List<OrdenReparacion>();
    }
}