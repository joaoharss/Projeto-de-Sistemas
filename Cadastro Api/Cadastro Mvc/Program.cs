using Cadastro_Mvc.Context;
using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Repository;
using Cadastro_Mvc.Services;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ContextDb>(opt => opt.UseInMemoryDatabase("CadastroList"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddScoped<IPessoa, PessoaService>();
            builder.Services.AddScoped<IEndereco, EnderecoService>();

            builder.Services.AddScoped<EnderecoRepository, EnderecoRepository>();
            builder.Services.AddScoped<PessoaRepository, PessoaRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
