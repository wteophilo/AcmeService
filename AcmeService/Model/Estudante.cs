using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcmeService.Model
{
    public class Estudante
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
        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataMatricula { get; set; }

        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> inscricoes { get; set; }
    }
}