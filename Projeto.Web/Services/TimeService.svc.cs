using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Web.Models;
using Projeto.Entity.Entities;
using Projeto.DAL.Persistence;

namespace Projeto.Web.Services
{
    public class TimeService : ITimeService
    {
        public string Cadastrar(TimeModelCadastro model)
        {
            try
            {
                Time t = new Time();
                t.Nome = model.Nome;
                t.DataFundacao = model.DataFundacao;

                TimeDal d = new TimeDal();
                d.Insert(t);

                return "Fornecedor" + t.Nome + ", cadastrado.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public TimeModelConsulta Editar(int id)
        {
            throw new NotImplementedException();
        }

        public string Atualizar(TimeModelEdicao model)
        {
            throw new NotImplementedException();
        }

        public string Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<TimeModelConsulta> Consultar()
        {
            try
            {
                List<TimeModelConsulta> lista = new List<TimeModelConsulta>();
                TimeDal d = new TimeDal();

                foreach(Time t in d.FindAll())
                {
                    TimeModelConsulta model = new TimeModelConsulta();
                    model.IdTime = t.IdTime;
                    model.Nome = t.Nome;
                    model.DataFundacao = t.DataFundacao.ToString("dd/MM/yyyy");

                    lista.Add(model);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }
    }
}
