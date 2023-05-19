using Charpter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Charpter.Controllers
{
    [Produces("appliccation/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {

        private readonly LivroRepositery? _livroRepositery;
        public LivrosController(LivroRepositery livroRepositery)
        {
            _livroRepositery = livroRepositery;
        }

        [HttpGet]

        public IActionResult ler()
        {
            try
            {
                return Ok( _livroRepositery.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
