

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class CompraProductoP
    {
        public int CompraId { get; set; }
        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }=null!;
        public int ProductoProveedorId { get; set; }
        [ForeignKey("ProductoProveedorId")]
        public ProductoProveedor ProductoProveedor { get; set; }=null!;

    }
}