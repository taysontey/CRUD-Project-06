using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Projeto.Web.Models
{
    [DataContract]
    public class TimeModelCadastro
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public DateTime DataFundacao { get; set; }
    }

    [DataContract]
    public class TimeModelConsulta
    {
        [DataMember]
        public int IdTime { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string DataFundacao { get; set; }
    }

    [DataContract]
    public class TimeModelEdicao
    {
        [DataMember]
        public int IdTime { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public DateTime DataFundacao { get; set; }
    }

    [DataContract]
    public class TimeModelDropDown
    {
        [DataMember]
        public int IdTime { get; set; }

        [DataMember]
        public string Nome { get; set; }
    }
}