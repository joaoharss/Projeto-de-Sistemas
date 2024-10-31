using Cadastro_Mvc.Model;
using System.Runtime.Serialization;

namespace Cadastro_Mvc.Contracts
{
    public interface IPessoa
    {
        Pessoa Create(PessoaDTO pessoa);

        Pessoa GetById(int id);
    }

    [DataContract]
    public class PessoaDTO
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Email { get; set;}
        [DataMember]
        public int Idade { get; set; }
        [DataMember]
        public IEnumerable<EnderecoDTO> Enderecos { get; set; }
    }
}
