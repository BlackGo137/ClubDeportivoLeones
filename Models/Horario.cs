using System.ComponentModel.DataAnnotations;
using ClubDeportivoLeones.Dto; // Asegúrate de importar el espacio de nombres donde están definidas las enumeraciones

namespace ClubDeportivoLeones.Models
{
    public class Horario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DiaSemana Dia { get; set; }

        [Required]
        public string? Hora { get; set; }


        // * ---- 1 : Muchos horarios tiene un Personal
        public int PersonalID { get; set; }
        public virtual Personal? Personal { get; set; }

        // * ---- 1 : Muchos horarios tiene un Cliente
        public int ClienteID { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
