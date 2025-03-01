using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public ActionResult<UsuarioResult> getById(int id) {

            Usuario? usuario = _usuarioService.obterPorId(id);
            
            if (usuario == null) {
                return NotFound(new Error($"Usuário {id}, não encontrado"));
            }

            return Ok(UsuarioResult.mapFrom(usuario));
        }

        [HttpGet("todos")]
        [Authorize]
        public ActionResult<List<UsuarioResult>> getAll() {
            List<UsuarioResult> reponse = UsuarioResult.mapFrom(_usuarioService.obterTodos());
            return Ok(reponse);
        }

        [HttpPost]
        public ActionResult criarUsuario([FromBody] NovoUsuarioRequest request) {
            Usuario? usuario = _usuarioService.obterPorLogin(request.login);    

            if (usuario != null) {
                return NotFound(new Error($"Login já em uso"));
            }    

            _usuarioService.criar(request);

            return Created();
        }

        [HttpPut]
        [Authorize]
        public ActionResult atualizarUsuario([FromBody] AtualizarUsuarioRequest request) {
            var login = User.Identity?.Name; 

            if (login == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }
            
            Usuario? usuario = _usuarioService.obterPorLogin(login);

            if (usuario == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            _usuarioService.atualizar(usuario, request);
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public ActionResult delete() {
            var login = User.Identity?.Name; 

            if (login == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            Usuario? usuario = _usuarioService.obterPorLogin(login);

            if (usuario == null) {
                return NotFound(new Error($"Usuário, não encontrado"));
            }

            _usuarioService.deletar(usuario);
            
            return Ok();
        }

    }

}