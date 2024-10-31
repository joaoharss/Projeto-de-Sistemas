using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Exceptions;
using Cadastro_Mvc.Model;
using Cadastro_Mvc.Repository;
using Cadastro_Mvc.Util;

namespace Cadastro_Mvc.Services
{
    public class PessoaService : IPessoa
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaService(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public Pessoa Create(PessoaDTO pessoa)
        {

            Pessoa pessoaEntidade = new Pessoa
            {
                Email = pessoa.Email,
                Idade = pessoa.Idade,
                Nome = pessoa.Nome,
                Enderecos = pessoa.Enderecos.Select(w => new Endereco
                {
                    Bairro = w.Bairro,
                    Cidade = w.Cidade,
                    Logradouro = w.Logradouro,
                    Numero = w.Numero,
                    UF = w.UF,
                }).ToList()
            };

            return _pessoaRepository.Create(pessoaEntidade);
        }

        public Pessoa? GetById(Guid id)
        {
            if (_pessoaRepository.GetById(id).IsNull())
                throw new BusinessException("Essa pessoa não existe.");

            return _pessoaRepository.GetById(id);
        }
    }
}
