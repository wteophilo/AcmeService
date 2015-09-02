using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AcmeService.Model
{
    [DataContract(IsReference = true)]
    public class Professor
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
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Titulação")]
        public string titulacao { get; set; }

        [DataMember]
        [UIHint("_Cursos")]
        public virtual ICollection<ProfessorCurso> leciona { get; set; }
    }
}