using TodoListMvc.Context;
using TodoListMvc.Model;
namespace TodoListMvc.Repository;

public class TodoRepository
{
    private readonly TodoDb _dbContext;
    
    public TodoRepository(TodoDb dbContext)
    {
        _dbContext = dbContext;
    }
    public Todo Create(Todo todo)
    {
        _dbContext.Todos.Add(todo);
        _dbContext.SaveChanges();
        return todo;
    }

    public Todo GetById(int id)
    {
        return _dbContext.Todos.Where(todo => todo.Id == id).FirstOrDefault();
    }

    public void Delete(int id)
    {
        if (GetById(id) == null)
            throw new Exception("Não foi possível deletar, não existe um Todo Item para esse Id.");

        _dbContext.Todos.Remove(GetById(id));
        _dbContext.SaveChanges();
    }

    public Todo Update(int id, Todo todo)
    {
        Todo objParaAtualizar = GetById(id);

        objParaAtualizar.Name = todo.Name;
        objParaAtualizar.IsComplete = todo.IsComplete;

        _dbContext.SaveChanges();

        return objParaAtualizar;
    }

    public IQueryable<Todo> GetAll()
    {
        return _dbContext.Todos;
    }
}