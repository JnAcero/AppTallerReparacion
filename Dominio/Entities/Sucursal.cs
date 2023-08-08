
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Sucursal:BaseEntityGeneric
    {
        public string Nombre { get; set; }=null!;
        public string Direccion { get; set; }=null!;
        public int CiudadId { get; set; }
        [ForeignKey("CiudadId")]
        public Ciudad Ciudad { get; set; }=null!;
        public ICollection<Empleado> Empleados { get; set; }=
        new List<Empleado>();
         public ICollection<ProductoSucursal> ProductosSucursales { get; set; }=
        new List<ProductoSucursal>();
         public ICollection<ClienteSucursal> ClientesSucursales { get; set; }=
        new List<ClienteSucursal>();
         public ICollection<Compra> Compras { get; set; }=
        new List<Compra>();
          
    }
}