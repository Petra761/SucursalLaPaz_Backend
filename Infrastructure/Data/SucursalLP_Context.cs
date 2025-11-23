using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sucursal_La_Paz_microservicio.Core.Entities;

    public class SucursalLP_Context : DbContext
    {
        public SucursalLP_Context (DbContextOptions<SucursalLP_Context> options)
            : base(options)
        {
        }
    public DbSet<Solicitud> Solicitud { get; set; } = default!;
    public DbSet<Sucursal> Sucursal { get; set; } = default!;
    public DbSet<ReporteVentaDiaria> ReporteVentaDiaria { get; set; } = default!;
    public DbSet<ReporteRendimientoLaboralDiario> ReporteRendimientoLaboralDiario { get; set; } = default!;
    public DbSet<ReporteRendimientoIndividual> ReporteRendimientoIndividual { get; set; } = default!;
    public DbSet<ReporteInventarioDiario> ReporteInventarioDiario { get; set; } = default!;
    public DbSet<ReporteIngresoDiario> ReporteIngresoDiario { get; set; } = default!;
    public DbSet<ReporteGastoDiario> ReporteGastoDiario { get; set; } = default!;
    public DbSet<GerenteSucursal> GerenteSucursal { get; set; } = default!;
    public DbSet<GastoDiarioDetalle> GastoDiarioDetalle { get; set; } = default!;
    public DbSet<DetalleIngresoDiario> DetalleIngresoDiario { get; set; } = default!;
}
