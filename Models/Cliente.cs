using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ClubDeportivoLeones.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Nombre { get; set; }
        
        [Required]
        public int  CI { get; set; }
        
        [Required]
        public DateOnly FechaNacimiento { get; set; }
        
        [Required]
        public int NroCelular { get; set; }
        
        public decimal MontoDeRegistro { get; set; }

        [Required]
        public DateTime FechaDeRegistro { get; set; }

        // 1 ---- * : Un cliente realiza muchos pagos
        [NotMapped]
        public string? Info { get { return $"{Nombre} - {CI}"; } }
        public virtual List<Pago>? Pagos { get; set; }


        // * ---- 1 : Muchos clientes Tienen un Personal
        public  int IDPersonal { get; set; }
        public virtual Personal? Personal { get; set; }


        // 1 --- * : Un cliente Puede tener Varios Horarios
        public virtual List<Horario>? Horarios { get; set; }
    }
}
