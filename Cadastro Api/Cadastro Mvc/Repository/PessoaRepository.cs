using Cadastro_Mvc.Context;
using Cadastro_Mvc.GenericRepository;
using Cadastro_Mvc.Model;
using Microsoft.EntityFrameworkCore; // Certifique-se de que você tem isso para usar Include


namespace Cadastro_Mvc.Repository
{
    public class PessoaRepository
    {
        private readonly Repository<Pessoa> _repository;

        public PessoaRepository(ContextDb dbContext)
        {
            _repository = new(dbContext);
        }

        public Pessoa Create(Pessoa pessoa)
        {
            _repository.Create(pessoa);
            return pessoa;
        }

        public Pessoa? GetById(Guid id)
        {
            return _repository.GetById(id);
        }
    }
}
