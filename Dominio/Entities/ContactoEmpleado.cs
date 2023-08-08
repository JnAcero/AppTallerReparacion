
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class ContactoEmpleado
    {
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado Empleado { get; set; }=null!;
        public int ContactoId { get; set; }
        [ForeignKey("ContactoId")]
        public Contacto Contacto { get; set; } =null!;
    }
}