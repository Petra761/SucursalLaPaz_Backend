using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sucursal_La_Paz_microservicio.Core.DTOs;
using Sucursal_La_Paz_microservicio.Core.Interfaces;

namespace Sucursal_La_Paz_microservicio.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudesController : ControllerBase
    {
        private readonly ISolicitudRepository context;
        public SolicitudesController(ISolicitudRepository context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSolicitudes()
        {
            var result = await context.GetSolicitudes();
            return Ok(result);
        }

        [HttpGet("by-codigo/{codigo}")]
        public async Task<IActionResult> GetByCod(string codigo)
        {
            var result = await context.GetByCodigo(codigo);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("by-destino/{codigoDestino}")]
        public async Task<IActionResult> GetByCodDestino(string codigoDestino)
        {
            var result = await context.GetByCodDestino(codigoDestino);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostSolicitud ([FromBody] SolicitudCreateDTO solicitud)
        {
            var result = await context.PostSolicitud(solicitud);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutSolicitud ([FromBody] SolicitudUpdateDTO solicitud)
        {
            var result = await context.PutSolicitud(solicitud);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{codigo}")]
        public async Task<IActionResult> DeleteSolicitud (string codigo)
        {
            var result = await context.DeleteSolicitud(codigo);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
