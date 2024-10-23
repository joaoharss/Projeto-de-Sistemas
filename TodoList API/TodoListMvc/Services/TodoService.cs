using Microsoft.EntityFrameworkCore;
using TodoListMvc.Context;
using TodoListMvc.Contracts;
using TodoListMvc.Model;

namespace TodoListMvc.Services
{
    public class TodoService : ITodo
    {
        private readonly Context.TodoDb _dbContext;

        public TodoService(TodoDb dbContext)
        {
            _dbContext = dbContext;
        }

        public Todo Create(Todo todo)
        {
            return _dbContext.Create(todo);
        }

        public void Delete(int id)
        {
            _dbContext.Delete(id);
        }

        public IEnumerable<Todo> Search()
        {
            return _dbContext.GetAll().ToList();
        }

        public Todo SearchById(int id)
        {
            return _dbContext.GetById(id);
        }

        public IEnumerable<Todo> SearchComplete()
        {
            return _dbContext.GetAll().Where(todo => todo.IsComplete);
        }

        public Todo Update(int id, Todo todo)
        {
            return _dbContext.Update(id, todo);
        }
    }
}
