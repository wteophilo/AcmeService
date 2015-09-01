using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProfessorService" in both code and config file together.
    [ServiceContract]
    public interface IProfessorService
    {
        [OperationContract]
        void adiciona(Professor professor);
        [OperationContract]
        void remove(Professor professor);
        [OperationContract]
        void atualiza(Professor professor);
        [OperationContract]
        Professor procura(int? id);
        [OperationContract]
        ICollection<Professor> lista();
        [OperationContract]
        Professor detalhe(int? id);
    }
}
