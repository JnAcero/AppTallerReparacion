

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuraciones
{
    public class ContactoEmpleadoConfig : IEntityTypeConfiguration<ContactoEmpleado>
    {
        public void Configure(EntityTypeBuilder<ContactoEmpleado> builder)
        {
            builder.HasKey(x =>new{x.EmpleadoId,x.ContactoId});
        }
    }
}