

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class DiagnosticoEmpleado:BaseEntityGeneric
    {
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado EmpleadoEncargado { get; set; } =null!;
        public int OrdenReparacionId { get; set; }
        [ForeignKey("OrdenReparacionId")]
        public OrdenReparacion OrdenReparacion { get; set; } =null!;
        public string Descripcion {get;set;} =null!;
        public DateTime Fecha {get; set;} 
    }
}