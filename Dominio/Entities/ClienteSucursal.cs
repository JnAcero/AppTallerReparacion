

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class ClienteSucursal
    {
        public int SucursalId { get; set; }
        [ForeignKey("SucursalId")]
        public Sucursal Sucursal { get; set; }=null!;
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }=null!;

    }
}