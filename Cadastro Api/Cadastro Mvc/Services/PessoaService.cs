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
        public Pessoa Create(Pessoa pessoa)
        {
            return _pessoaRepository.Create(pessoa);
        }

        public Pessoa GetById(int id)
        {
            return _pessoaRepository.GetById(id);
        }
    }
}
