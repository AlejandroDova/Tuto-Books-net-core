using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Libro
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="El titulo es obligatorio")]
        [StringLength(50,ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripccion es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres")]
        [Display(Name = "Descripcción")]
        public string Descripccion { get; set; }

        [Required(ErrorMessage = "La fehca es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }

    }
}
