using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AcmeService.Model
{
    [DataContract(IsReference = true)]
    public class Inscricao
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        [Display(Name = "Curso")]
        public int cursoId { get; set; }

        [DataMember]
        [Display(Name = "Estudante")]
        public int estudanteId { get; set; }

        [DataMember]
        [DataType(DataType.Time)]
        [Display(Name = "Data de Inscrição")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataInscricao { get; set; }

        [DataMember]
        public virtual Estudante estudante { get; set; }

        [DataMember]
        public virtual Curso curso { get; set; }
    }
}