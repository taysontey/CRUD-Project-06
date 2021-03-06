﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Web.Models;

namespace Projeto.Web.Services
{
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
