

namespace Dominio.Entities
{
    public class Region:BaseEntityGeneric
    {
        public string Nombre { get; set; }=null!;
        public ICollection<Ciudad> Ciudades { get; set; }=
        new List<Ciudad>();

    }
}