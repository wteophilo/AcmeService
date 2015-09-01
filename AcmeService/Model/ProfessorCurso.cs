using System.ComponentModel.DataAnnotations;

namespace AcmeService.Model
{
    public class ProfessorCurso
    {
        public int id { get; set; }
        [Display(Name = "Curso")]
        public int cursoId { get; set; }
        [Display(Name = "Professor")]
        public int professorId { get; set; }

        public virtual Professor professor { get; set; }
        public virtual Curso curso { get; set; }
    }
}