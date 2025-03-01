public class Livro
{
    public int Id { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public Usuario usuario { get; set; }

    private Livro() {
        this.nome = "";
        this.descricao = "";
        this.usuario = new Usuario("", "", "");
    }
    public Livro(string nome, string descricao, Usuario usuario)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.usuario = usuario;
    }

    public static Livro mapFrom(Usuario usuario, LivroRequest request) {
        return new Livro(request.nome, request.descricao, usuario);
    }

    public void updateValuesFrom(LivroRequest request) {
        this.nome = request.nome;
        this.descricao = request.descricao;
    }
}