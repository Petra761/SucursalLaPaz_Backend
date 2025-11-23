using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal_La_Paz_microservicio.Core.Entities
{
    public class Sucursal
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("codigo")]
        public string Codigo { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("direccion")]
        public string Direccion { get; set; }

        [Column("ciudad")]
        public string Ciudad { get; set; }

        [Column("departamento")]
        public string Departamento { get; set; }

        [Column("ultima_actualizacion")]
        public DateTime UltimaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
