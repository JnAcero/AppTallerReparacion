

namespace Dominio.Entities
{
    public class OrdenDetalleReparacion
    {
        public int OrdenReparacionId { get; set; }
        public OrdenReparacion OrdenReparacion { get; set; }
        public int DetalleReparacionId {get; set; }
        public DetalleReparacion DetalleReparacion {get; set; }
    }
}