using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteRendimientoLaboralDiario
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("cod_sucursal")]
        public string CodSucursal { get; set; }

        [Column("fecha")]
        public DateOnly Fecha { get; set; }

        [Column("empleados_activos")]
        public int EmpleadosActivos { get; set; }

        [Column("horas_trabajadas_totales")]
        public decimal HorasTrabajadasTotales { get; set; }

        [Column("costo_laboral_total")]
        public decimal CostoLaboralTotal { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
