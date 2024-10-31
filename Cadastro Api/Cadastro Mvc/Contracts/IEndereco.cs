using Cadastro_Mvc.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Cadastro_Mvc.Contracts
{
    public interface IEndereco
    {
        Endereco Create(EnderecoDTO endereco);
    }

    [DataContract]
    public class EnderecoDTO
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public string UF { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public virtual int IdPessoa { get; set; }
    }
}
