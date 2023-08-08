

namespace Dominio.Entities
{
    public class DetalleReparacion:BaseEntityGeneric
    {
        public string Nombre { get; set; } =null!;
        public string? Descripcion { get; set; }
        public decimal Costo { get; set; }
        public ICollection<OrdenDetalleReparacion> OrdenesReparaciones { get; set; }
        =new List<OrdenDetalleReparacion>();   
        public ICollection<ProductoReparacion> ProductosReparaciones { get; set;}=
        new List<ProductoReparacion>();
    }
}