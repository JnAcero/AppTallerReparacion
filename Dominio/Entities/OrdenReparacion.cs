using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities
{
    public class OrdenReparacion
    {
        [Key]
        public int NumeroOrden { get; set; }
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Vehiculo Vehiculo { get; set; } =null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string ?EstadoReparacion { get; set; }
         public ICollection<DiagnosticoEmpleado> DiagnosticosEmpleados { get; set;}
        =new List<DiagnosticoEmpleado>();
        public DiagnosticoInicial DiagnosticoInicial { get; set; }=null!;
        public InspeccionInicial InspeccionInicial { get; set; }=null!;
        public Factura Factura { get; set; }
        public ICollection<OrdenDetalleReparacion> OrdenesReparaciones {get;set;} =
        new List<OrdenDetalleReparacion>();

    }
}