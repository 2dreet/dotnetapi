public class Usuario
{
    public int Id { get; set; }
    public string nome { get; set; }

    private Usuario(string nome)
    {
        this.nome = nome;
    }

    public static Usuario create(string name) {
        return new Usuario(name);
    }
}