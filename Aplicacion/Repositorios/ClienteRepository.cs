
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repositorios
{
    public class ClienteRepository : GenericRepoPersona<Cliente>, ICliente
    {
        public ClienteRepository(TallerRepDbContext context) : base(context)
        {
        }
    }
}