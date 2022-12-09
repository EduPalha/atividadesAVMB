using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        [HttpGet("Hello")]
        public string HelloWorld()
        {
            return "Hello API Net6";
        }

        [HttpGet("Nome")]
        public string Nome()
        {
            return "Eduardo Pavani Palharini";
        }

        [HttpGet("Idade")]
        public string Idade()
        {
            return "27 anos";
        }

        [HttpPost]
        [Route("nomes")]
        public string nomePost([FromBody] string nome)
        {
            if (nome == "Eduardo")
            {
                return "27 anos";
            }
            else
            {
                return "Idade não disponível!";
            }
        }
    }
}