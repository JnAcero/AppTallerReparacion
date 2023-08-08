
namespace Dominio.Entities
{
    public class CategoriaProducto:BaseEntityGeneric
    {
        public string NombreCategoria { get; set; }=null!;
        public ICollection<Producto> Productos {get; set;} =
        new List<Producto>();       
    }
}