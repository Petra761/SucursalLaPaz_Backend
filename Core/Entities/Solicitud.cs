using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class Solicitud
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("codigo")]
        public string Codigo { get; set; }

        [Required]
        [Column("codigo_solicitante")]
        public string CodSolicitante { get; set; }

        [Required]
        [Column("codigo_destino")]
        public string CodDestino { get; set; }

        [Required]
        [Column("tipo_solicitud")]
        public string TipoSolicitud { get; set; }

        [Required]
        [Column("asunto")]
        public string Asunto { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Required]
        [Column("estado")]
        public string Estado { get; set; } = "PedienteAprobacion";

        [Required]
        [Column("prioridad")]
        public string Prioridad { get; set; }

        [Column("fecha_creacion")]
        public DateOnly FechaCreacion { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [Column("fecha_aprobacion_rechazo")]
        public DateOnly? FechaAprobacionRechazo { get; set; }

        [Column("codigo_aprobador_rechazador")]
        public string? CodAprobadorRechazador { get; set; }

        [Column("justificacion_rechazo")]
        public string? JustificacionRechazo { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;

    }
}
