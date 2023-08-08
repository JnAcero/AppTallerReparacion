
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class DiagnosticoInicial:BaseEntityGeneric
    {
        public int OrdenReparacionId { get; set; }
        [ForeignKey("OrdenReparacionId")]
        public OrdenReparacion OrdenReparacion { get; set; }=null!;
        public string ?DiagnosticoCliente { get; set; }
        public string ? TiempoEstimadoReparacion {get; set; }
    
    }
}