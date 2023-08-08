
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities
{
    public class BaseEntityPersona
    {
        public int Id { get; set; }
        public int NumIdentificacion { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; } = null!;
        [MaxLength(50)]
        public string Apellido { get; set; }= null!;
        [MaxLength(25)]
        public string Telefono { get; set; }= null!;
        [MaxLength(50)]
        public string Direccion { get; set; }= null!;
        public string Correo { get; set; }= null!;
        
    }
}