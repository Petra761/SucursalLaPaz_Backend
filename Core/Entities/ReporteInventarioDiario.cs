using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class ReporteInventarioDiario
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

        [Column("codigo_producto")]
        public string CodProducto { get; set; }

        [Column("stock_final_dia")]
        public int StockFinalDia { get; set; }

        [Column("entrada_del_dia")]
        public int EntradaDelDia { get; set; }

        [Column("salida_del_dia")]
        public int SalidaDelDia { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
