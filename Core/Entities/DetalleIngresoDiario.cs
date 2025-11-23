using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class DetalleIngresoDiario
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("id_reporte_ingreso_diario")]
        public Guid IdReporteIngresoDiario { get; set; }

        [Column("codigo_ingreso_original")]
        public string CodIngresoOriginal { get; set; }

        [Column("tipo_ingreso")]
        public string TipoIngreso { get; set; }

        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("detalle")]
        public string Detalle { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
