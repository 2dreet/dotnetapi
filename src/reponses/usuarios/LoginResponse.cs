public class LoginResponse
{
    public UsuarioResult usuario { get; set; }
    public string token { get; set; }

    public LoginResponse(UsuarioResult usuario, string token)
    {
        this.usuario = usuario;
        this.token = token;
    }
}