using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Projeto.Web.Models
{
    [DataContract]
    public class JogadorModelCadastro
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Apelido { get; set; }

        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public string Posicao { get; set; }

        [DataMember]
        public int IdTime { get; set; }
    }

    [DataContract]
    public class JogadorModelConsulta
    {
        [DataMember]
        public int IdJogador { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Apelido { get; set; }

        [DataMember]
        public string DataNascimento { get; set; }

        [DataMember]
        public string Posicao { get; set; }

        [DataMember]
        public string Time { get; set; }
    }

    [DataContract]
    public class JogadorModelEdicao
    {
        [DataMember]
        public int IdJogador { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Apelido { get; set; }

        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public string Posicao { get; set; }

        [DataMember]
        public int IdTime { get; set; }
    }
}