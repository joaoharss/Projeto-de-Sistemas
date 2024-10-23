using Microsoft.AspNetCore.Mvc;
using TodoListMvc.Contracts;
using TodoListMvc.Model;

namespace TodoListMvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodo _todoContract;

        public TodoController(ITodo todoContract)
        {
            _todoContract = todoContract;
        }

        [HttpGet("/GetAll")]
        public ActionResult Search()
        {
            var todos = _todoContract.Search();
            return Json(todos);
        }

        [HttpGet("/GetCompleteds")]
        public ActionResult SearchCompleteds()
        {
            var todos = _todoContract.SearchComplete();
            return Json(todos);
        }

        [HttpGet("/GetById/{id}")]
        public ActionResult SearchById(int id)
        {
            var todo = _todoContract.SearchById(id);
            return Json(todo);
        }

        [HttpPost("/Create/")]
        public ActionResult<Todo> Create(Todo todo)
        {
            return Json(_todoContract.Create(todo));
        }

        [HttpPut("/Update/{id}")]
        public ActionResult<Todo> Update(int id, Todo todo)
        {
            return Json(_todoContract.Update(id, todo));
        }

        [HttpDelete("/Delete/")]
        public ActionResult<Todo> Delete(int id)
        {
            _todoContract.Delete(id);
            return Ok();
        }


    }
}
