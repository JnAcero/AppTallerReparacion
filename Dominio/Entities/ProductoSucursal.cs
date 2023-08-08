
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class ProductoSucursal
    {
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto producto { get; set; }=null!;
        public int SucursalId { get; set; }
        [ForeignKey("SucursalId")]
        public Sucursal Sucursal { get; set; }=null!;
        public  decimal Stock { get; set; }
        public decimal StockMinimo { get; set; }  
    }
}