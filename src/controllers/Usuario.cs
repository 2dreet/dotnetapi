using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService; // Atribuindo a dependência injetada
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> getById(int id) {

            Usuario? usuario = _usuarioService.obterPorId(id);
            
            if (usuario == null) {
                return NotFound(new Error($"Usuário {id}, não encontrado"));
            }

            return Ok(usuario);
        }

        [HttpPost]
        public void criarUsuario(NovoUsuario novoUsuario) {
            _usuarioService.criar(novoUsuario.Nome);
        }

        [HttpPut("{id}")]
        public ActionResult atualizarUsuario(int id, NovoUsuario novoUsuario) {
            Boolean status = _usuarioService.atualizar(id, novoUsuario.Nome);
            return status ? Ok() : NotFound(new Error($"Usuário {id}, não encontrado"));;
        }

        [HttpGet("todos")]
        public ActionResult<List<Usuario>> getAll() {
            return Ok(_usuarioService.obterTodos());
        }

    }

}