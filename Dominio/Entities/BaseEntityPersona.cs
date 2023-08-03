
namespace Dominio.Entities
{
    public class BaseEntityPersona
    {
        public int Id { get; set; }
        public int NumIdentificacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; }= null!;
        public string Telefono { get; set; }= null!;
        public string Direccion { get; set; }= null!;
        public string Correo { get; set; }= null!;
        
    }
}