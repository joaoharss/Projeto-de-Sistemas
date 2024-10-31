using Cadastro_Mvc.Context;
using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.GenericRepository;
using Cadastro_Mvc.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Mvc.Repository
{
    public class EnderecoRepository
    {
        private readonly Repository<Endereco> _repository;

        public EnderecoRepository(ContextDb dbContext)
        {
            _repository = new(dbContext);
        }


        public Endereco Create(Endereco endereco)
        {
            Endereco entidadeEndereco = _repository.Create(endereco);
            
            return entidadeEndereco;
        }
    }
}
