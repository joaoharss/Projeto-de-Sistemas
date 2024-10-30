using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Cadastro_Mvc.Repository;
using Cadastro_Mvc.Util;

namespace Cadastro_Mvc.Services
{
    public class EnderecoService : IEndereco
    {
        private readonly EnderecoRepository _enderecoRepository;
        private readonly PessoaRepository _pessoaRepository;
        public EnderecoService(EnderecoRepository enderecoRepository, PessoaRepository pessoaRepository)
        {
            _enderecoRepository = enderecoRepository;
            _pessoaRepository = pessoaRepository;

        }
        public Endereco Create(Endereco endereco)
        {
            if (_pessoaRepository.GetById(endereco.IdPessoa).IsNull())
                throw new NullReferenceException("Essa pessoa não existe.");

            return _enderecoRepository.Create(endereco);
        }
    }
}
