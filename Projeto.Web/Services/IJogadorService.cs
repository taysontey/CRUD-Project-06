using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Web.Models;

namespace Projeto.Web.Services
{
    [ServiceContract]
    public interface IJogadorService
    {
        [OperationContract]
        List<TimeModelDropDown> CarregarTimes();

        [OperationContract]
        string Cadastrar(JogadorModelCadastro model);

        [OperationContract]
        JogadorModelConsulta Editar(int id);

        [OperationContract]
        string Atualizar(JogadorModelEdicao model);

        [OperationContract]
        string Excluir(int id);

        [OperationContract]
        List<JogadorModelConsulta> Consultar();
    }
}
