
public class UsuarioService : IUsuarioService
{

    public static List<Usuario> usuarios = new List<Usuario>();

   

    public void criar(string name)
    {
        Usuario usuario = Usuario.create(name);

        usuario.Id = usuarios.Count + 1;

        UsuarioService.usuarios.Add(usuario);
    }

    public Usuario? obterPorId(int id)
    {
        return UsuarioService.usuarios.FirstOrDefault(usuario => usuario.Id == id);
    }

    public List<Usuario> obterTodos()
    {
        return UsuarioService.usuarios;
    }

    public Boolean atualizar(int id, string nome)
    {
        Usuario? usuario = obterPorId(id);
        if (usuario == null) {
            return false;
        }

        usuario.nome = nome;

        return true;

    }
}