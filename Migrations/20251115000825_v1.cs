using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sucursal_La_Paz_microservicio.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GerenteSucursal",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    ci = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha_inicio_gerencia = table.Column<DateOnly>(type: "date", nullable: false),
                    fecha_fin_gerencia = table.Column<DateOnly>(type: "date", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerenteSucursal", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerenteSucursal");
        }
    }
}
