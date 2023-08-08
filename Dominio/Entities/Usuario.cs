
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities
{
    public class Usuario:BaseEntityGeneric
    {
        public string NombreUsuario { get; set; } = null!;
        [Required]
        [MaxLength(15)]
        public string Password { get; set; }=null!;
        public int IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public virtual TipoUsuario TipUsuario { get; set; }= null!;
    }
}