using System.ComponentModel.DataAnnotations;

namespace MathiasVera_TallerAppWebMVC.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El estadio debe estar ubicado en algun lado")]
        public string Direccion { get; set; }
        [StringLength(25, ErrorMessage = "No sobrepasar de los 25 caracteres")]
        public string Ciudad { get; set; }
        [MinLength(7000)]
        public int Capacidad { get; set; }
    }
}
