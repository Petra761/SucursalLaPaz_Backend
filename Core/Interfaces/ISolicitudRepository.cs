using Sucursal_La_Paz_microservicio.Core.DTOs;

namespace Sucursal_La_Paz_microservicio.Core.Interfaces
{
    public interface ISolicitudRepository
    {
        Task<List<SolicitudDTO>> GetSolicitudes();
        Task<SolicitudDTO?> GetByCodigo(string codigo);
        Task<List<SolicitudDTO>> GetByCodDestino(string codigo);
        Task<SolicitudDTO> PostSolicitud(SolicitudCreateDTO solicitud);
        Task<SolicitudDTO> PutSolicitud(SolicitudUpdateDTO solicitud);
        Task<SolicitudDTO> DeleteSolicitud(string codigo);
    }
}
