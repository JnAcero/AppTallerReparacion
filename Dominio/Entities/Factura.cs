

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Factura
    {
        [Key]
        public int NumeroFactura { get; set; }
        public int OrdenReparacionId { get; set; }
        [ForeignKey("OrdenReparacionId")]
        public OrdenReparacion OrdenReparacion { get; set;}
        public decimal ValorReparacion { get; set; }
        public decimal ValorManoObra { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalPagar { get; set; }
        public DateTime FechaFacturacion {get;set;}     
    }
}