using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sucursal_La_Paz_microservicio.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleIngresoDiario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    id_reporte_ingreso_diario = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo_ingreso_original = table.Column<string>(type: "text", nullable: false),
                    tipo_ingreso = table.Column<string>(type: "text", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    detalle = table.Column<string>(type: "text", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleIngresoDiario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GastoDiarioDetalle",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    id_reporte_gasto_diario = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo_gasto_original = table.Column<string>(type: "text", nullable: false),
                    tipo_gasto = table.Column<string>(type: "text", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    detalle = table.Column<string>(type: "text", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastoDiarioDetalle", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "ReporteGastoDiario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    total_gastos_operativos = table.Column<decimal>(type: "numeric", nullable: false),
                    total_gastos_laborales = table.Column<decimal>(type: "numeric", nullable: false),
                    total_otros_gastos = table.Column<decimal>(type: "numeric", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteGastoDiario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporteIngresoDiario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    total_ingreso_por_ventas = table.Column<decimal>(type: "numeric", nullable: false),
                    total_otros_ingresos = table.Column<decimal>(type: "numeric", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteIngresoDiario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporteInventarioDiario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    codigo_producto = table.Column<string>(type: "text", nullable: false),
                    stock_final_dia = table.Column<int>(type: "integer", nullable: false),
                    entrada_del_dia = table.Column<int>(type: "integer", nullable: false),
                    salida_del_dia = table.Column<int>(type: "integer", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteInventarioDiario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporteRendimientoIndividual",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    codigo_empleado = table.Column<string>(type: "text", nullable: false),
                    observaciones = table.Column<string>(type: "text", nullable: false),
                    fecha_observacion = table.Column<DateOnly>(type: "date", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteRendimientoIndividual", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporteRendimientoLaboralDiario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    empleados_activos = table.Column<int>(type: "integer", nullable: false),
                    horas_trabajadas_totales = table.Column<decimal>(type: "numeric", nullable: false),
                    costo_laboral_total = table.Column<decimal>(type: "numeric", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteRendimientoLaboralDiario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporteVentaDiaria",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    cod_sucursal = table.Column<string>(type: "text", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    total_ventas = table.Column<decimal>(type: "numeric", nullable: false),
                    cantidad_pedidos = table.Column<int>(type: "integer", nullable: false),
                    total_productos_vendidos = table.Column<int>(type: "integer", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporteVentaDiaria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    codigo_solicitante = table.Column<string>(type: "text", nullable: false),
                    codigo_destino = table.Column<string>(type: "text", nullable: false),
                    tipo_solicitud = table.Column<string>(type: "text", nullable: false),
                    asunto = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: false),
                    prioridad = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateOnly>(type: "date", nullable: false),
                    fecha_aprobacion_rechazo = table.Column<DateOnly>(type: "date", nullable: true),
                    codigo_aprobador_rechazador = table.Column<string>(type: "text", nullable: true),
                    justificacion_rechazo = table.Column<string>(type: "text", nullable: true),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    ciudad = table.Column<string>(type: "text", nullable: false),
                    departamento = table.Column<string>(type: "text", nullable: false),
                    ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleIngresoDiario");

            migrationBuilder.DropTable(
                name: "GastoDiarioDetalle");

            migrationBuilder.DropTable(
                name: "GerenteSucursal");

            migrationBuilder.DropTable(
                name: "ReporteGastoDiario");

            migrationBuilder.DropTable(
                name: "ReporteIngresoDiario");

            migrationBuilder.DropTable(
                name: "ReporteInventarioDiario");

            migrationBuilder.DropTable(
                name: "ReporteRendimientoIndividual");

            migrationBuilder.DropTable(
                name: "ReporteRendimientoLaboralDiario");

            migrationBuilder.DropTable(
                name: "ReporteVentaDiaria");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
