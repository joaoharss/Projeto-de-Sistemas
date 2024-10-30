using Cadastro_Mvc.Context;
using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Microsoft.EntityFrameworkCore; // Certifique-se de que você tem isso para usar Include


namespace Cadastro_Mvc.Repository
{
    public class PessoaRepository
    {
        private readonly ContextDb _dbContext;

        public PessoaRepository(ContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public Pessoa Create(Pessoa pessoa)
        {
            _dbContext.Pessoas.Add(pessoa);
            _dbContext.SaveChanges();

            return pessoa;
        }

        public Pessoa GetById(int id)
        {
            var pessoa = _dbContext.Pessoas
                .Include(w => w.Enderecos)
                .Where(todo => todo.Id == id).FirstOrDefault();
            return pessoa;
        }
    }
}
