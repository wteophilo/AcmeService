using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AcmeService.Model
{
    [DataContract(IsReference = true)]
    public class Estudante
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
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Sobrenome")]
        public string sobrenome { get; set; }

        [DataMember]
        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataMatricula { get; set; }

        [DataMember]
        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> inscricoes { get; set; }
    }
}