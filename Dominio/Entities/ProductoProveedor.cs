using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities
{
    public class ProductoProveedor
    {
        [Key]
        [MaxLength(15)]
        [Required]
        public int Id { get; set;}
        public int ProductoPersonalId { get; set;}
        [ForeignKey("ProductoPersonalId")]
        public Producto Producto { get; set;}=null!;
        public int ProveedorId { get; set;}
        [ForeignKey("ProveedorId")]
        public Proveedor Proveedor { get; set;} =null!;
   
    }
}