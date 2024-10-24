using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MathiasVera_TallerAppWebMVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id {  get; set; }
        [Required(ErrorMessage = "El equipo necesita un nombre")]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        [NotNull]
        public bool AceptaExtranjeros { get; set; }
    }
}
