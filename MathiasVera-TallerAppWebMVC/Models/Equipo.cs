﻿using System.ComponentModel.DataAnnotations;

namespace MathiasVera_TallerAppWebMVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Titulos { get; set; }
        public bool AceptaExtranjeros { get; set; }
    }
}
