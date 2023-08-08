using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuraciones
{
    public class OrdenReparacionConfig : IEntityTypeConfiguration<OrdenDetalleReparacion>
    {
        public void Configure(EntityTypeBuilder<OrdenDetalleReparacion> builder)
        {
           builder.HasKey(x =>new{x.DetalleReparacionId,x.OrdenReparacionId} );
        }
    }
}