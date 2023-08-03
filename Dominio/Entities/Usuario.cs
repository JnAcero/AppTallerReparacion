
namespace Dominio.Entities
{
    public class Usuario:BaseEntityGeneric
    {
        private string password;
        public Usuario(string contraseña)
        {
            password = contraseña;
        }
        public string Password {
            set{
                password = value;
            }}
        public string NombreUsuario { get; set; } = null!;
        
        public int IdTipoUsuario { get; set; }
        public virtual TipoUsuario TipUsuario { get; set; }= null!;
    }
}