using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Cadastro_Mvc.Util.Controller;

namespace Cadastro_Mvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoa _pessoaContract;

        public PessoaController(IPessoa pessoaContract)
        {
            _pessoaContract = pessoaContract;
        }

        [HttpPost("/Create/")]
        public ActionResult<Pessoa> Create([FromBody] Pessoa pessoa)
        {
            return JsonOptionsUtil.Create(_pessoaContract.Create(pessoa));
        }

        [HttpGet("/GetById/{id}")]
        public ActionResult<Pessoa> GetById(int id)
        {
            return JsonOptionsUtil.Create(_pessoaContract.GetById(id));
        }
    }
}
