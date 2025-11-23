using System.ComponentModel.DataAnnotations;

namespace Sucursal_La_Paz_microservicio.Core.DTOs
{
    public class SolicitudDTO
    {
        public string Codigo { get; set; } = string.Empty;
        public string CodSolicitante { get; set; } = string.Empty;
        public string CodDestino { get; set; } = string.Empty;
        public string TipoSolicitud { get; set; } = string.Empty;
        public string Asunto { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Prioridad { get; set; } = string.Empty;
        public DateOnly FechaCreacion { get; set; }
        public DateOnly? FechaAprobacionRechazo { get; set; }
        public string? CodAprobadorRechazador { get; set; }
        public string? JustificacionRechazo { get; set; }
        public DateTime UltimaActualizacion { get; set; }
    }
    public class SolicitudCreateDTO
    {
        [Required]
        public string CodSolicitante { get; set; }
        [Required]
        public string CodDestino { get; set; }
        [Required]
        public string TipoSolicitud { get; set; }
        [Required]
        public string Asunto { get; set; }
        public string? Descripcion { get; set; }
        [Required]
        public string Prioridad { get; set; }
    }
    public class SolicitudUpdateDTO {
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Estado { get; set; }
        public string? JustificacionRechazo { get; set; }
    }
}
