using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoListMvc.Model;

namespace TodoListMvc.Context
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();

        public Todo Create(Todo todo)
        {
            Todos.Add(todo);
            SaveChanges();
            return todo;
        }

        public Todo GetById(int id)
        {
            return Todos.Where(todo => todo.Id == id).FirstOrDefault();
        }

        public void Delete(int id)
        {
            if (GetById(id) == null)
                throw new Exception("Não foi possível deletar, não existe um Todo Item para esse Id.");

            Todos.Remove(GetById(id));
            SaveChanges();
        }

        public Todo Update(int id, Todo todo)
        {
            Todo objParaAtualizar = GetById(id);

            objParaAtualizar.Name = todo.Name;
            objParaAtualizar.IsComplete = todo.IsComplete;

            SaveChanges();

            return objParaAtualizar;
        }

        public IQueryable<Todo> GetAll()
        {
            return Todos;
        }

    }
}
