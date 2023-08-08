
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class InspeccionInicial:BaseEntityGeneric
    {
        public int OrdenReparacionId { get; set; }
        [ForeignKey("OrdenReparacionId")]
        public OrdenReparacion OrdenReparacion { get; set; }=null!;
        public string? EstadoPuertas { get; set; }
        public string? EstadoRadio { get; set; }
        public string? EstadoCabina { get; set; }
        public string? EstadoMotor {get;set;}
        public string? EstadoFluidos { get; set; }

        
    }
}