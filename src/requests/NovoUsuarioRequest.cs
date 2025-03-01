public class NovoUsuarioRequest
{
    public string nome { get; set; }

    public string login { get; set; }

    public string senha { get; set; }

    public NovoUsuarioRequest(string nome, string login, string senha)
    {
        this.nome = nome;
        this.login = login;
        this.senha = senha;
    }
}