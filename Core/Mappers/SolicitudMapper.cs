using Sucursal_La_Paz_microservicio.Core.DTOs;
using Sucursal_La_Paz_microservicio.Core.Entities;

namespace Sucursal_La_Paz_microservicio.Core.Mappers
{
    public static class SolicitudMapper
    {
        public static SolicitudDTO ToDTO(this Solicitud entidad)
        {
            return new SolicitudDTO
            {
                Codigo = entidad.Codigo,
                CodSolicitante = entidad.CodSolicitante,
                CodDestino = entidad.CodDestino,
                TipoSolicitud = entidad.TipoSolicitud,
                Asunto = entidad.Asunto,
                Descripcion = entidad.Descripcion,
                Estado = entidad.Estado,
                Prioridad = entidad.Prioridad,
                FechaCreacion = entidad.FechaCreacion,
                FechaAprobacionRechazo = entidad.FechaAprobacionRechazo,
                CodAprobadorRechazador = entidad.CodAprobadorRechazador,
                JustificacionRechazo = entidad.JustificacionRechazo,
                UltimaActualizacion = entidad.UltimaActualizacion
            };
        }
    }
}
