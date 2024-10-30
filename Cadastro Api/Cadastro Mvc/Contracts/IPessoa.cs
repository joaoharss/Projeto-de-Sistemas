using Cadastro_Mvc.Model;
using System.Runtime.Serialization;

namespace Cadastro_Mvc.Contracts
{
    public interface IPessoa
    {
        Pessoa Create(Pessoa pessoa);

        Pessoa GetById(int id);
    }

    [DataContract]
    public class PessoaDc
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Email { get; set;}
        [DataMember]
        public int Idade { get; set; }
        [DataMember]
        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}
