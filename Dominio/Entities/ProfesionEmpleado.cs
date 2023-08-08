
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class ProfesionEmpleado
    {
        public int IdEmpleado { get; set; }
         [ForeignKey("IdEmpleado")]
        public Empleado Empleado { get; set; }=null!;
        public int IdProfesion { get; set; }
         [ForeignKey("IdProfesion")]
        public Profesion Prefesion { get; set; }=null!;
        
    }
}