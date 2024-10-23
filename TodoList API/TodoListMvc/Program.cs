
using Microsoft.EntityFrameworkCore;
using TodoListMvc.Context;
using TodoListMvc.Contracts;
using TodoListMvc.Services;

namespace TodoListMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //Toda vez que for pedido um ITodo, cria uma instância de TodoService.
            builder.Services.AddScoped<ITodo, TodoService>();

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
