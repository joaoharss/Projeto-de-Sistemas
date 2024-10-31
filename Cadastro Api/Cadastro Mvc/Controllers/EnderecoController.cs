using Cadastro_Mvc.Contracts;
using Cadastro_Mvc.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Cadastro_Mvc.Util.Controller;
using static Cadastro_Mvc.Util.Methods;

namespace Cadastro_Mvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : Controller
    {
        private readonly IEndereco _enderecoContract;

        public EnderecoController(IEndereco enderecoContract)
        {
            _enderecoContract = enderecoContract;
        }

        [HttpPost("/Endereco/Create/")]
        public ActionResult<Endereco> Create([FromBody] EnderecoDTO endereco)
        {
            return JsonOptionsUtil.Create(_enderecoContract.Create(endereco));
        }
    }
}
