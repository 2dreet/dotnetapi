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
        public ActionResult<UsuarioResult> getById(int id) {

            Usuario? usuario = _usuarioService.obterPorId(id);
            
            if (usuario == null) {
                return NotFound(new Error($"Usuário {id}, não encontrado"));
            }

            return Ok(UsuarioResult.mapFrom(usuario));
        }

        [HttpPost]
        public void criarUsuario(NovoUsuarioRequest request) {
            _usuarioService.criar(request);
        }

        [HttpPut("{id}")]
        public ActionResult atualizarUsuario(int id, AtualizarUsuarioRequest request) {
            Boolean status = _usuarioService.atualizar(id, request);
            return status ? Ok() : NotFound(new Error($"Usuário {id}, não encontrado"));;
        }

        [HttpGet("todos")]
        public ActionResult<List<UsuarioResult>> getAll() {
            List<UsuarioResult> reponse = UsuarioResult.mapFrom(_usuarioService.obterTodos());
            return Ok(reponse);
        }

    }

}