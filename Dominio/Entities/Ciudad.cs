

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Ciudad:BaseEntityGeneric
    {
        public string Nombre { get; set; }=null!;
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public Region Dpto { get; set; }=null!;
        public ICollection<Sucursal> Sucursales { get; set; } = new List<Sucursal>();

        
    }
}