using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteIngresoDiario
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

        [Column("total_ingreso_por_ventas")]
        public decimal TotalIngresoPorVentas { get; set; }

        [Column("total_otros_ingresos")]
        public decimal TotalOtrosIngresos { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
