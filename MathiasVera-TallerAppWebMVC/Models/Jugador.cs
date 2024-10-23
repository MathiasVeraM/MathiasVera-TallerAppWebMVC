using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathiasVera_TallerAppWebMVC.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(120)]
        [Required(ErrorMessage = "Por favor ingresa el nombre del jugador")]
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        [Range(18,60, ErrorMessage = "No entra dentro del rango de edad")]
        public int Edad {  get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
