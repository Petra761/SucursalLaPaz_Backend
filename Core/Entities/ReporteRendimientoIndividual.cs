using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteRendimientoIndividual
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("cod_sucursal")]
        public string CodSucursal { get; set; }

        [Column("codigo_empleado")]
        public string CodEmpleado { get; set; }

        [Column("observaciones")]
        public string Observaciones { get; set; }

        [Column("fecha_observacion")]
        public DateOnly FechaObservacion { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
