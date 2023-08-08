
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Proveedor:BaseEntityGeneric
    {
        public string NIT {get; set;}=null!;
        public int TipoProveedorId {get; set;}
        [ForeignKey("TipoProveedorId")]
        public TipoProveedor TipoProveedor {get; set;}
        public string Nombre {get; set;} =null!;
        public string ?Email {get; set;}
        public string ?Direccion { get; set; } 
        public ICollection<Compra> Compras {get; set; }
        =new List<Compra>();
        public ICollection<ProductoProveedor> ProductosProveedores {get; set; }
        =new List<ProductoProveedor>();



        
    }
}