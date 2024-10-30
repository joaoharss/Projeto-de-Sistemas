using Cadastro_Mvc.Context;
using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Mvc.Repository
{
    public class EnderecoRepository
    {
        private readonly ContextDb _dbContext;

        public EnderecoRepository (ContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public Endereco Create(Endereco endereco)
        {
            _dbContext.Enderecos.Add(endereco);
            _dbContext.SaveChanges(); 

            // Após salvar, busca o endereço criado com a pessoa associada
            var enderecoComPessoa = _dbContext.Enderecos
                .Include(e => e.Pessoa) 
                .FirstOrDefault(e => e.Id == endereco.Id);

            return enderecoComPessoa; 
        }
    }
}
