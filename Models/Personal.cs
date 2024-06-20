using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubDeportivoLeones.Models
{
    public class Personal
    {
        [Key]
        public int ID { get; set; }

        public string? Nombre { get; set; }
        [Required]
        public int CI { get; set; }
        [Required]

        public DateOnly FechaDeNacimiento { get; set; }
        [Required]

        public string? Email { get; set; }
        [Required]

        public int NroCel {  get; set; }


        [NotMapped]
        public string? Info { get { return $"{Nombre} - {CI}"; } }
        // 1 ---- * : Un personal esta acargo de muchos clientes
        public virtual List<Cliente>? Clientes { get; set; }

        // 1 ---- * : Un Personal Tiene muchos Horarios
        public virtual List<Horario>? Horarios { get; set; }

    }
}
