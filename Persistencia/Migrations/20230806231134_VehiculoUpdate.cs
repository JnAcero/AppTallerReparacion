using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class VehiculoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TiposVehiculo_TipoVehivuloId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "TipoVehivuloId",
                table: "Vehiculos",
                newName: "TipoVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_TipoVehivuloId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_TipoVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TiposVehiculo_TipoVehiculoId",
                table: "Vehiculos",
                column: "TipoVehiculoId",
                principalTable: "TiposVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TiposVehiculo_TipoVehiculoId",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "TipoVehiculoId",
                table: "Vehiculos",
                newName: "TipoVehivuloId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_TipoVehiculoId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_TipoVehivuloId");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TiposVehiculo_TipoVehivuloId",
                table: "Vehiculos",
                column: "TipoVehivuloId",
                principalTable: "TiposVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        } 
    }
}
