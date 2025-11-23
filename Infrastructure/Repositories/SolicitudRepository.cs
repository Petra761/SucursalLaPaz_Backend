using Microsoft.EntityFrameworkCore;
using Sucursal_La_Paz_microservicio.Core.DTOs;
using Sucursal_La_Paz_microservicio.Core.Entities;
using Sucursal_La_Paz_microservicio.Core.Interfaces;
using Sucursal_La_Paz_microservicio.Core.Mappers;

namespace Sucursal_La_Paz_microservicio.Infrastructure.Repositories
{
    public class SolicitudRepository : ISolicitudRepository
    {
        private readonly SucursalLP_Context context;
        public SolicitudRepository(SucursalLP_Context context)
        {
            this.context = context;
        }

        public async Task<List<SolicitudDTO>> GetSolicitudes()
        {
            var solicitudes = await context.Solicitud
                .AsNoTracking()
                .Where(s => s.Estado != "Eliminada")
                .ToListAsync();
            return solicitudes.Select(s => s.ToDTO()).ToList();
        }

        public async Task<SolicitudDTO?> GetByCodigo(string codigo)
        {
            var solicitud = await context.Solicitud
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Codigo == codigo && s.Estado != "Eliminada");

            if (solicitud == null)
            {
                return null;
            }
            
            return solicitud.ToDTO();
        }

        public async Task<List<SolicitudDTO>> GetByCodDestino(string codigo)
        {
            var solicitudes = await context.Solicitud
                .AsNoTracking()
                .Where(s => s.CodDestino == codigo && s.Estado != "Eliminada")
                .ToListAsync();

            if (solicitudes == null) return null;

            return solicitudes.Select(s => s.ToDTO()).ToList();
        }

        public async Task<SolicitudDTO> PostSolicitud(SolicitudCreateDTO solicitud)
        {
            var nuevaSolicitud = new Solicitud
            {
                Codigo = await GenerarCodigoSolicitud(),
                CodSolicitante = solicitud.CodSolicitante,
                CodDestino = solicitud.CodDestino,
                TipoSolicitud = solicitud.TipoSolicitud,
                Asunto = solicitud.Asunto,
                Descripcion = solicitud.Descripcion,
                Prioridad = solicitud.Prioridad,
            };

            context.Solicitud.Add(nuevaSolicitud);
            await context.SaveChangesAsync();

            return nuevaSolicitud.ToDTO();
        }

        public async Task<SolicitudDTO> PutSolicitud(SolicitudUpdateDTO solicitud)
        {
            var solicitudExistente = await context.Solicitud
                .FirstOrDefaultAsync(s => s.Codigo == solicitud.Codigo);

            if (solicitudExistente == null)
            {
                return null;
            }

            solicitudExistente.Estado = solicitud.Estado;
            if (solicitud.JustificacionRechazo != null) solicitudExistente.JustificacionRechazo = solicitud.JustificacionRechazo;
            var usuarioActual = await context.GerenteSucursal
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Estado == "Activo");
            solicitudExistente.CodAprobadorRechazador = usuarioActual.Ci;

            await context.SaveChangesAsync();

            return solicitudExistente.ToDTO();
        }

        public async Task<SolicitudDTO> DeleteSolicitud(string codigo)
        {
            var solicitudExistente = await context.Solicitud
                .FirstOrDefaultAsync(s => s.Codigo == codigo);
            if (solicitudExistente == null)
            {
                return null;
            }
            
            solicitudExistente.Estado = "Eliminada";

            await context.SaveChangesAsync();
            return solicitudExistente.ToDTO();

        }

        private async Task<string> GenerarCodigoSolicitud()
        {
            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month;

            var lastSolicitud = await context.Solicitud
                .Where(s => s.FechaCreacion.Year == year && s.FechaCreacion.Month == month)
                .OrderByDescending(s => s.Codigo)
                .Select(s => s.Codigo)
                .FirstOrDefaultAsync();

            int sequenceNumber = 1;

            if (lastSolicitud != null)
            {
                var parts = lastSolicitud.Split('-');
                if (parts.Length == 3 && int.TryParse(parts[2], out int lastSequence))
                {
                    sequenceNumber = lastSequence + 1;
                }
            }

            return $"SOL-{year}{month:D2}-{sequenceNumber:D3}";
        }
    }
}
