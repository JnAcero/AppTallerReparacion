using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class TallerRepDbContext : DbContext
    {
        public TallerRepDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}