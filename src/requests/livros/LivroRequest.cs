public class LivroRequest
{
    public string nome { get; set; }
    public string descricao { get; set; }

    public LivroRequest(string nome, string descricao)
    {
        this.nome = nome;
        this.descricao = descricao;
    }
}