using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        
        
        private readonly IUsuarioService _usuarioService;
        private readonly ILivroService _livroService;

        public LivroController(IUsuarioService usuarioService, ILivroService livroService)
        {
            _usuarioService = usuarioService;
            _livroService = livroService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<List<LivroResult>> obterTodos() {
            var login = User.Identity?.Name; 

            if (login == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }
            
            Usuario? usuario = _usuarioService.obterPorLogin(login);

            if (usuario == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            return Ok(LivroResult.mapFrom(_livroService.obterTodos(usuario)));
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<LivroResult> obterPorId(int id) {
            var login = User.Identity?.Name; 

            if (login == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }
            
            Usuario? usuario = _usuarioService.obterPorLogin(login);

            if (usuario == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            Livro? livro = _livroService.obterPorId(usuario, id);

            if (livro == null) {
                return NotFound(new Error($"Livro, não encontrado"));
            }

            return Ok(LivroResult.mapFrom(livro));
        }

        [HttpPost]
        [Authorize]
        public ActionResult criar([FromBody] LivroRequest request) {
            var login = User.Identity?.Name; 

            if (login == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }
            
            Usuario? usuario = _usuarioService.obterPorLogin(login);

            if (usuario == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            _livroService.criar(usuario, request);    

            return Ok();

        }
        

        

    }
}