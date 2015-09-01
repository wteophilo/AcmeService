using AcmeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInscricaoService" in both code and config file together.
    [ServiceContract]
    public interface IInscricaoService
    {
        [OperationContract]
        void adiciona(Inscricao inscricao);
        [OperationContract]
        void remove(Inscricao inscricao);
        [OperationContract]
        void atualiza(Inscricao inscricao);
        [OperationContract]
        Inscricao procura(int? id);
        [OperationContract]
        ICollection<Inscricao> lista();
        [OperationContract]
        Inscricao detalhe(int? id);
    }
}
