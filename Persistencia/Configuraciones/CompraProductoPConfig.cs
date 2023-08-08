
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Configuraciones
{
    public class CompraProductoPConfig : IEntityTypeConfiguration<CompraProductoP>
    {
        public void Configure(EntityTypeBuilder<CompraProductoP> builder)
        {
           builder.HasKey(p =>new{p.CompraId,p.ProductoProveedorId});
        }
    }
}