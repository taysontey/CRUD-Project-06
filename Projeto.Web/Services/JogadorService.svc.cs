using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Entity.Entities;
using Projeto.DAL.Persistence;
using Projeto.Web.Models;

namespace Projeto.Web.Services
{
    public class JogadorService : IJogadorService
    {
        public List<TimeModelDropDown> CarregarTimes()
        {
            try
            {
                var lista = new List<TimeModelDropDown>();
                TimeDal d = new TimeDal();

                foreach(Time t in d.FindAll())
                {
                    var model = new TimeModelDropDown();
                    model.IdTime = t.IdTime;
                    model.Nome = t.Nome;

                    lista.Add(model);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        public string Cadastrar(JogadorModelCadastro model)
        {
            try
            {
                Jogador j = new Jogador();
                j.Nome = model.Nome;
                j.Apelido = model.Apelido;
                j.DataNascimento = model.DataNascimento;
                j.Posicao = model.Posicao;
                j.IdTime = model.IdTime;

                JogadorDal d = new JogadorDal();
                d.Insert(j);

                return "Jogador cadastrado.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public JogadorModelConsulta Editar(int id)
        {
            try
            {
                JogadorDal d = new JogadorDal();
                Jogador j = d.FindById(id);

                if (j != null)
                {
                    var model = new JogadorModelConsulta();
                    model.IdJogador = j.IdJogador;
                    model.Nome = j.Nome;
                    model.Apelido = j.Apelido;
                    model.DataNascimento = j.DataNascimento.ToString("dd/MM/yyyy");
                    model.Time = j.Time.Nome;

                    return model;
                }
                else
                {
                    throw new Exception("Jogador não encontrado.");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        public string Atualizar(JogadorModelEdicao model)
        {
            try
            {
                Jogador j = new Jogador();
                j.IdJogador = model.IdJogador;
                j.Nome = model.Nome;
                j.Apelido = model.Apelido;
                j.DataNascimento = model.DataNascimento;
                j.Posicao = model.Posicao;
                j.IdTime = model.IdTime;

                JogadorDal d = new JogadorDal();
                d.Update(j);

                return "Jogador atualizado.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Excluir(int id)
        {
            try
            {
                JogadorDal d = new JogadorDal();
                Jogador j = d.FindById(id);

                if (j != null)
                {
                    d.Delete(j);
                    return "Jogador excluído.";
                }
                else
                {
                    return "Jogador não encontrado.";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<JogadorModelConsulta> Consultar()
        {
            try
            {
                var lista = new List<JogadorModelConsulta>();
                JogadorDal d = new JogadorDal();

                foreach (Jogador j in d.FindAll())
                {
                    var model = new JogadorModelConsulta();
                    model.IdJogador = j.IdJogador;
                    model.Nome = j.Nome;
                    model.Apelido = j.Apelido;
                    model.DataNascimento = j.DataNascimento.ToString("dd/MM/yyyy");
                    model.Posicao = j.Posicao;
                    model.Time = j.Time.Nome;

                    lista.Add(model);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }
    }
}
