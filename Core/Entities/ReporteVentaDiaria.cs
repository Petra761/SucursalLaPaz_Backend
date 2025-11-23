using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteVentaDiaria
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

        [Column("total_ventas")]
        public decimal TotalVentas { get; set; }

        [Column("cantidad_pedidos")]
        public int CantidadPedidos { get; set; }

        [Column("total_productos_vendidos")]
        public int TotalProductosVendidos { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
