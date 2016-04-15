using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Web.Models;

namespace Projeto.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITimeService" in both code and config file together.
    [ServiceContract]
    public interface ITimeService
    {
        [OperationContract]
        string Cadastrar(TimeModelCadastro model);

        [OperationContract]
        TimeModelConsulta Editar(int id);

        [OperationContract]
        string Atualizar(TimeModelEdicao model);

        [OperationContract]
        string Excluir(int id);

        [OperationContract]
        List<TimeModelConsulta> Consultar();
    }
}
