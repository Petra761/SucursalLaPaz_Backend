using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class GerenteSucursal
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("ci")]
        public string Ci { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cod_sucursal")]
        public string CodSucursal { get; set; }

        [Column("fecha_inicio_gerencia")]
        public DateOnly FechaInicioGerencia { get; set; }

        [Column("fecha_fin_gerencia")]
        public DateOnly? FechaFinGerencia { get; set; } // Nullable si el gerente está activo

        [Column("estado")]
        public string Estado { get; set; } = "Activo"; // Valor por defecto

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
