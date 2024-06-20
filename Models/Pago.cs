using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivoLeones.Models
{
    public class Pago 
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public int NroRecibo { get; set; }

        [Required]
        public int Dia { get; set; }

        [Required]
        public int Mes { get; set; }

        [Required]
        public int Anio { get; set; }

        [Required]
        public decimal Total { get; set; }

        // * ----- 1 : Muchos a uno
        public int UsuarioID { get; set; }
        public int ClienteID { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get;set; }

    }
}