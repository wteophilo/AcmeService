using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProfessorCursoService" in both code and config file together.
    [ServiceContract]
    public interface IProfessorCursoService
    {
        [OperationContract]
        void adiciona(ProfessorCurso professorCurso);
        [OperationContract]
        void remove(ProfessorCurso professorCurso);
        [OperationContract]
        void atualiza(ProfessorCurso professorCurso);
        [OperationContract]
        ProfessorCurso procura(int? id);
        [OperationContract]
        ICollection<ProfessorCurso> lista();
        [OperationContract]
        ProfessorCurso detalhe(int? id);
    }
}
