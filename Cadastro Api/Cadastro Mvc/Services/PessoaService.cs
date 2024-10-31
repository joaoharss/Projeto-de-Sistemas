using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Cadastro_Mvc.Repository;

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

        public Pessoa GetById(int id)
        {
            return _pessoaRepository.GetById(id);
        }
    }
}
