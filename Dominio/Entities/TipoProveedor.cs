

namespace Dominio.Entities
{
    public class TipoProveedor : BaseEntityGeneric
    {
        public string Tipo { get; set; } = null!;
        public string? MonedaTransaccion { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; } =
              new List<Proveedor>();
    }
}