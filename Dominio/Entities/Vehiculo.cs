
namespace Dominio.Entities
{
    public class Vehiculo:BaseEntityGeneric
    {
        public string Placa { get; set; } = null!;
        public string Marca { get; set; }= null!;
        public string ? Modelo { get; set; }
        public double Kilometraje { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }= null!;
        public int IdTipoVehiculo { get; set; }
        public virtual TipoVehivulo TipoVehivulo { get; set; }= null!;
    }
}