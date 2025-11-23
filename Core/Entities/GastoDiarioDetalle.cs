using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class GastoDiarioDetalle
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("id_reporte_gasto_diario")]
        public Guid IdReporteGastoDiario { get; set; }

        [Column("codigo_gasto_original")]
        public string CodGastoOriginal { get; set; }

        [Column("tipo_gasto")]
        public string TipoGasto { get; set; }

        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("detalle")]
        public string Detalle { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
