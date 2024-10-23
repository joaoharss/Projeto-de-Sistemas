using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TodoListMvc.Context;
using TodoListMvc.Contracts;
using TodoListMvc.Model;
using TodoListMvc.Repository;

namespace TodoListMvc.Services
{
    public class TodoService : ITodo
    {
            private readonly TodoRepository _todoRepository;

            public TodoService(TodoRepository todoRepository)
            {
                _todoRepository = todoRepository;
            }

            public Todo Create(Todo todo)
            {
                return _todoRepository.Create(todo);
            }

            public void Delete(int id)
            {
                _todoRepository.Delete(id);
            }

            public IEnumerable<Todo> Search()
            {
                return _todoRepository.GetAll().ToList();
            }

            public Todo SearchById(int id)
            {
                return _todoRepository.GetById(id);
            }

            public IEnumerable<Todo> SearchComplete()
            {
                return _todoRepository.GetAll().Where(todo => todo.IsComplete);
            }

            public Todo Update(int id, Todo todo)
            {
                return _todoRepository.Update(id, todo);
            }
        }
}
