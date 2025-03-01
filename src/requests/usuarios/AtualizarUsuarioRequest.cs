public class AtualizarUsuarioRequest
{
    public string nome { get; set; }

    public AtualizarUsuarioRequest(string nome)
    {
        this.nome = nome;
    }
}