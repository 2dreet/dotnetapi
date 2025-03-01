using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IJwtService _jwtService;
        public LoginController(IUsuarioService _usuarioService, IJwtService _jwtService)
        {
            this._usuarioService = _usuarioService;
            this._jwtService = _jwtService;
        }

        [HttpPost]
        public ActionResult<LoginResponse> login([FromBody] LoginRequest request) {
            Usuario? usuario = _usuarioService.login(request);

            if (usuario == null) {
                return NotFound(new Error("Usuário ou senha invalidos!"));
            }

            string token = _jwtService.make(usuario);

            return Ok(new LoginResponse(UsuarioResult.mapFrom(usuario), token));
        }
    }

}