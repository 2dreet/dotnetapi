public class LoginRequest
{
    public string login { get; set; }

    public string senha { get; set; }

    public LoginRequest(string login, string senha)
    {
        this.login = login;
        this.senha = senha;
    }
}