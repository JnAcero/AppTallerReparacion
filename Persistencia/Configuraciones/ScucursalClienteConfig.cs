
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuraciones
{
    public class ScucursalClienteConfig : IEntityTypeConfiguration<ClienteSucursal>
    {
        public void Configure(EntityTypeBuilder<ClienteSucursal> builder)
        {
           builder.HasKey(x => new{x.SucursalId,x.ClienteId});
        }
    }
}