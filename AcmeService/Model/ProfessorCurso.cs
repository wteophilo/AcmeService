using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AcmeService.Model
{

    [DataContract(IsReference = true)]
    public class ProfessorCurso
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        [Display(Name = "Curso")]
        public int cursoId { get; set; }

        [DataMember]
        [Display(Name = "Professor")]
        public int professorId { get; set; }

        [DataMember]
        public virtual Professor professor { get; set; }

        [DataMember]
        public virtual Curso curso { get; set; }
    }
}