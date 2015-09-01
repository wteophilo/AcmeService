using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcmeService.Model
{
    public class Curso
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string nome { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        [StringLength(50, MinimumLength = 3)]
        public string descricao { get; set; }
        [Display(Name = "Data Limite de Inscrição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataLimiteInscricao { get; set; }

        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> inscricoes { get; set; }
        public virtual ICollection<ProfessorCurso> leciona { get; set; }
    }
}