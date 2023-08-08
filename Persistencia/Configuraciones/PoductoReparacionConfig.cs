
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuraciones
{
    public class PoductoReparacionConfig : IEntityTypeConfiguration<ProductoReparacion>
    {
        public void Configure(EntityTypeBuilder<ProductoReparacion> builder)
        {
            builder.HasKey(x =>new{x.ProductoId,x.DetalleReparacionId});
        }
    }
}