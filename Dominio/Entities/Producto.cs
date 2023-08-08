

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Producto:BaseEntityGeneric
    {
        public int CategoriaProductoId { get; set; }
        [ForeignKey("CategoriaProductoId")]
        public CategoriaProducto ProdutoCategoria { get; set; }
        public string Nombre { get; set; }=null!;
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public ICollection<OrdenDetalleReparacion> OrdenesReparaciones { get; set; }
        =new List<OrdenDetalleReparacion>();
        public ICollection<ProductoProveedor> ProductosProveedor { get; set; }
        =new List<ProductoProveedor>();
        public ICollection<ProductoSucursal> ProductosSucursasles { get; set; }
        =new List<ProductoSucursal>();



        
    }
}