
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuraciones
{
    public class SucursalProductoConfig : IEntityTypeConfiguration<ProductoSucursal>
    {
        public void Configure(EntityTypeBuilder<ProductoSucursal> builder)
        {
            builder.HasKey(x => new{x.SucursalId,x.ProductoId});
        }
    }
}