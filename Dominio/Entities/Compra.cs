

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Compra
    {
        [Key]
        public int RefCompra { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public Proveedor Proveedor { get; set; }=null!;
        public int SucursalId { get; set; }
        [ForeignKey("SucursalId")]
        public  Sucursal Sucursal {get; set;}=null!;
        public DateTime FechaCompra { get; set; }
        public decimal SubTotal {get; set;}
        public decimal Total {get; set;}
        public string MetodoPago { get; set; }=null!;
        public string? TerminosCondiciones { get; set; }
        public ICollection<CompraProductoP> ComprasProductosProv{ get; set; }
        =new List<CompraProductoP>();

        
    }
}