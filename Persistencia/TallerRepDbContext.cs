using System.Reflection;
using Dominio.Entities;
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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Arl> Arl { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CategoriaProducto> CategoriasProductos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteSucursal> ClientesSucursales { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraProductoP> ComprasProductosP { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<ContactoEmpleado> ContactosEmpleados { get; set; }
        public DbSet<DetalleReparacion> DetalleReparaciones { get; set; }
        public DbSet<DiagnosticoEmpleado> DiagnosticosEmpleados { get; set; }
        public DbSet<DiagnosticoInicial> DiagnosticosIniciales { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Eps> Eps { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<InspeccionInicial> InspeccionesIniciales { get; set; }
        public DbSet<OrdenDetalleReparacion> OrdenDetalleReparaciones { get; set; }
        public DbSet<OrdenReparacion> OrdenesReparacion { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoProveedor> ProductosProveedores { get; set; }
        public DbSet<ProductoReparacion> ProductosReparaciones { get; set; }
        public DbSet<ProductoSucursal> ProductosSucursales { get; set; }
        public DbSet<Profesion> Profesiones { get; set; }
        public DbSet<ProfesionEmpleado> ProfesionesEmpleados { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<TipoProveedor> TipoProveedores { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<TipoVehivulo> TiposVehiculo { get; set; }
       // public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}