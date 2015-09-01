using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstudanteService" in both code and config file together.
    [ServiceContract]
    public interface IEstudanteService
    {
        [OperationContract]
        void adiciona(Estudante estudante);
        [OperationContract]
        void remove(Estudante estudante);
        [OperationContract]
        void atualiza(Estudante estudante);
        [OperationContract]
        Estudante procura(int? idestudante);
        [OperationContract]
        ICollection<Estudante> listaEstudante();
        [OperationContract]
        Estudante detalhe(int? idEstudante);
    }
}
