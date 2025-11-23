using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteGastoDiario
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

        [Column("total_gastos_operativos")]
        public decimal TotalGastosOperativos { get; set; }

        [Column("total_gastos_laborales")]
        public decimal TotalGastosLaborales { get; set; }

        [Column("total_otros_gastos")]
        public decimal TotalOtrosGastos { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
