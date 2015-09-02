using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AcmeService.Model
{
    [DataContract(IsReference = true)]
    public class Curso
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string nome { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Descrição")]
        [StringLength(50, MinimumLength = 3)]
        public string descricao { get; set; }

        [DataMember]
        [Display(Name = "Data Limite de Inscrição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataLimiteInscricao { get; set; }

        [DataMember]
        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> inscricoes { get; set; }
        [DataMember]
        [UIHint("_Professor")]
        public virtual ICollection<ProfessorCurso> leciona { get; set; }
    }
}