using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Arl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreArl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arl", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCargo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriasProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCategoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasProductos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Parentesco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleReparaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Costo = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleReparaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEps = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Profesiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Carrera = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Universidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesiones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoProveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MonedaTransaccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProveedores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Permisos = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposVehiculo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaProductoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioCompra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_CategoriasProductos_CategoriaProductoId",
                        column: x => x.CategoriaProductoId,
                        principalTable: "CategoriasProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudades_Regiones_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NIT = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoProveedorId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_TipoProveedores_TipoProveedorId",
                        column: x => x.TipoProveedorId,
                        principalTable: "TipoProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TiposUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductosReparaciones",
                columns: table => new
                {
                    DetalleReparacionId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosReparaciones", x => new { x.ProductoId, x.DetalleReparacionId });
                    table.ForeignKey(
                        name: "FK_ProductosReparaciones_DetalleReparaciones_DetalleReparacionId",
                        column: x => x.DetalleReparacionId,
                        principalTable: "DetalleReparaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosReparaciones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CiudadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sucursales_Ciudades_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductosProveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductoPersonalId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductosProveedores_Productos_ProductoPersonalId",
                        column: x => x.ProductoPersonalId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosProveedores_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    NumIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    RefCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MetodoPago = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TerminosCondiciones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.RefCompra);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    TipoContratacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEps = table.Column<int>(type: "int", nullable: false),
                    IdArl = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaCumpleaños = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: true),
                    NumIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Arl_IdArl",
                        column: x => x.IdArl,
                        principalTable: "Arl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Cargos_IdCargo",
                        column: x => x.IdCargo,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Eps_IdEps",
                        column: x => x.IdEps,
                        principalTable: "Eps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Empleados_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductosSucursales",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StockMinimo = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosSucursales", x => new { x.SucursalId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_ProductosSucursales_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosSucursales_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClientesSucursales",
                columns: table => new
                {
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesSucursales", x => new { x.SucursalId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_ClientesSucursales_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesSucursales_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kilometraje = table.Column<double>(type: "double", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    IdTipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    TipoVehivuloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_TiposVehiculo_TipoVehivuloId",
                        column: x => x.TipoVehivuloId,
                        principalTable: "TiposVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComprasProductosP",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    ProductoProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasProductosP", x => new { x.CompraId, x.ProductoProveedorId });
                    table.ForeignKey(
                        name: "FK_ComprasProductosP_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "RefCompra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprasProductosP_ProductosProveedores_ProductoProveedorId",
                        column: x => x.ProductoProveedorId,
                        principalTable: "ProductosProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactosEmpleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    ContactoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactosEmpleados", x => new { x.EmpleadoId, x.ContactoId });
                    table.ForeignKey(
                        name: "FK_ContactosEmpleados_Contactos_ContactoId",
                        column: x => x.ContactoId,
                        principalTable: "Contactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactosEmpleados_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfesionesEmpleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdProfesion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesionesEmpleados", x => new { x.IdProfesion, x.IdEmpleado });
                    table.ForeignKey(
                        name: "FK_ProfesionesEmpleados_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesionesEmpleados_Profesiones_IdProfesion",
                        column: x => x.IdProfesion,
                        principalTable: "Profesiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenesReparacion",
                columns: table => new
                {
                    NumeroOrden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoReparacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesReparacion", x => x.NumeroOrden);
                    table.ForeignKey(
                        name: "FK_OrdenesReparacion_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiagnosticosEmpleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    OrdenReparacionId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticosEmpleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosticosEmpleados_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticosEmpleados_OrdenesReparacion_OrdenReparacionId",
                        column: x => x.OrdenReparacionId,
                        principalTable: "OrdenesReparacion",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiagnosticosIniciales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrdenReparacionId = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoCliente = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiempoEstimadoReparacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticosIniciales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosticosIniciales_OrdenesReparacion_OrdenReparacionId",
                        column: x => x.OrdenReparacionId,
                        principalTable: "OrdenesReparacion",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    NumeroFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrdenReparacionId = table.Column<int>(type: "int", nullable: false),
                    ValorReparacion = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValorManoObra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalPagar = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FechaFacturacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.NumeroFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_OrdenesReparacion_OrdenReparacionId",
                        column: x => x.OrdenReparacionId,
                        principalTable: "OrdenesReparacion",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InspeccionesIniciales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrdenReparacionId = table.Column<int>(type: "int", nullable: false),
                    EstadoPuertas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoRadio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCabina = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoMotor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoFluidos = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspeccionesIniciales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspeccionesIniciales_OrdenesReparacion_OrdenReparacionId",
                        column: x => x.OrdenReparacionId,
                        principalTable: "OrdenesReparacion",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenDetalleReparaciones",
                columns: table => new
                {
                    OrdenReparacionId = table.Column<int>(type: "int", nullable: false),
                    DetalleReparacionId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDetalleReparaciones", x => new { x.DetalleReparacionId, x.OrdenReparacionId });
                    table.ForeignKey(
                        name: "FK_OrdenDetalleReparaciones_DetalleReparaciones_DetalleReparaci~",
                        column: x => x.DetalleReparacionId,
                        principalTable: "DetalleReparaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDetalleReparaciones_OrdenesReparacion_OrdenReparacionId",
                        column: x => x.OrdenReparacionId,
                        principalTable: "OrdenesReparacion",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDetalleReparaciones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_RegionId",
                table: "Ciudades",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdUsuario",
                table: "Clientes",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesSucursales_ClienteId",
                table: "ClientesSucursales",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProveedorId",
                table: "Compras",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_SucursalId",
                table: "Compras",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasProductosP_ProductoProveedorId",
                table: "ComprasProductosP",
                column: "ProductoProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactosEmpleados_ContactoId",
                table: "ContactosEmpleados",
                column: "ContactoId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticosEmpleados_EmpleadoId",
                table: "DiagnosticosEmpleados",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticosEmpleados_OrdenReparacionId",
                table: "DiagnosticosEmpleados",
                column: "OrdenReparacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticosIniciales_OrdenReparacionId",
                table: "DiagnosticosIniciales",
                column: "OrdenReparacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdArl",
                table: "Empleados",
                column: "IdArl");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdCargo",
                table: "Empleados",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdEps",
                table: "Empleados",
                column: "IdEps");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdUsuario",
                table: "Empleados",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_OrdenReparacionId",
                table: "Facturas",
                column: "OrdenReparacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InspeccionesIniciales_OrdenReparacionId",
                table: "InspeccionesIniciales",
                column: "OrdenReparacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalleReparaciones_OrdenReparacionId",
                table: "OrdenDetalleReparaciones",
                column: "OrdenReparacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalleReparaciones_ProductoId",
                table: "OrdenDetalleReparaciones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesReparacion_VehiculoId",
                table: "OrdenesReparacion",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaProductoId",
                table: "Productos",
                column: "CategoriaProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosProveedores_ProductoPersonalId",
                table: "ProductosProveedores",
                column: "ProductoPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosProveedores_ProveedorId",
                table: "ProductosProveedores",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosReparaciones_DetalleReparacionId",
                table: "ProductosReparaciones",
                column: "DetalleReparacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosSucursales_ProductoId",
                table: "ProductosSucursales",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionesEmpleados_IdEmpleado",
                table: "ProfesionesEmpleados",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoProveedorId",
                table: "Proveedores",
                column: "TipoProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_CiudadId",
                table: "Sucursales",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdTipoUsuario",
                table: "Usuarios",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ClienteId",
                table: "Vehiculos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoVehivuloId",
                table: "Vehiculos",
                column: "TipoVehivuloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesSucursales");

            migrationBuilder.DropTable(
                name: "ComprasProductosP");

            migrationBuilder.DropTable(
                name: "ContactosEmpleados");

            migrationBuilder.DropTable(
                name: "DiagnosticosEmpleados");

            migrationBuilder.DropTable(
                name: "DiagnosticosIniciales");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "InspeccionesIniciales");

            migrationBuilder.DropTable(
                name: "OrdenDetalleReparaciones");

            migrationBuilder.DropTable(
                name: "ProductosReparaciones");

            migrationBuilder.DropTable(
                name: "ProductosSucursales");

            migrationBuilder.DropTable(
                name: "ProfesionesEmpleados");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "ProductosProveedores");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "OrdenesReparacion");

            migrationBuilder.DropTable(
                name: "DetalleReparaciones");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Profesiones");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Arl");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "CategoriasProductos");

            migrationBuilder.DropTable(
                name: "TipoProveedores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TiposVehiculo");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
