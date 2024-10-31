using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Exceptions;
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
        public Endereco Create(EnderecoDTO endereco)
        {
            if (_pessoaRepository.GetById(endereco.IdPessoa).IsNull())
                throw new BusinessException("Essa pessoa não existe.");

            Endereco enderecoEntity = new Endereco
            {
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                IdPessoa = endereco.IdPessoa,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                UF = endereco.UF,
            };

            return _enderecoRepository.Create(enderecoEntity);
        }
    }
}
