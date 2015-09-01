using System;
using System.ComponentModel.DataAnnotations;

namespace AcmeService.Model
{
    public class Inscricao
    {
        public int id { get; set; }
        [Display(Name = "Curso")]
        public int cursoId { get; set; }
        [Display(Name = "Estudante")]
        public int estudanteId { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Data de Inscrição")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataInscricao { get; set; }

        public virtual Estudante estudante { get; set; }
        public virtual Curso curso { get; set; }
    }
}