public class Usuario
{
    public int Id { get; set; }
    public string nome { get; set; }

    public string login { get; set; }

    public string senha { get; set; }

    public Usuario(string nome, string login, string senha)
    {
        this.nome = nome;
        this.login = login;
        this.senha = senha;
    }

    public static Usuario mapFrom(NovoUsuarioRequest request) {
        return new Usuario(request.nome, request.login, request.senha);
    }

    public void updateValuesFrom(AtualizarUsuarioRequest request) {
        this.nome = request.nome;
    }
}