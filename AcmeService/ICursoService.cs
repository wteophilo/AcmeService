using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICursoService" in both code and config file together.
    [ServiceContract]
    public interface ICursoService
    {
        [OperationContract]
        void adiciona(Curso curso);
        [OperationContract]
        void remove(Curso curso);
        [OperationContract]
        void atualiza(Curso curso);
        [OperationContract]
        Curso procura(int? id);
        [OperationContract]
        ICollection<Curso> lista();
        [OperationContract]
        Curso detalhe(int? id);
    }
}
