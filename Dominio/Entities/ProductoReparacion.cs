
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class ProductoReparacion
    {
        public int DetalleReparacionId { get; set; }
        [ForeignKey("DetalleReparacionId")]
        public DetalleReparacion DetalleReparacion { get; set; }=null!;
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }=null!;

        
    }
}