using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcmeService.Model
{
    public class Professor
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string nome { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Sobrenome")]
        public string sobrenome { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Titulação")]
        public string titulacao { get; set; }
        public virtual ICollection<ProfessorCurso> leciona { get; set; }
    }
}