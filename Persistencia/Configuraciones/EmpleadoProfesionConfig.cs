using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Configuraciones
{
    public class EmpleadoEProfesionEmpleadoConfig : IEntityTypeConfiguration<ProfesionEmpleado>
    {
        public void Configure(EntityTypeBuilder<ProfesionEmpleado> builder)
        {
            builder.HasKey(x =>new{x.IdProfesion,x.IdEmpleado});
        }
    }
}