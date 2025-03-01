
using MinhaApi.repositories;

public class UsuarioService : IUsuarioService
{

    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository _usuarioRepository)
    {
        this._usuarioRepository = _usuarioRepository;
    }

    public void criar(NovoUsuarioRequest request)
    {
        _usuarioRepository.criar(Usuario.mapFrom(request));
    }

    public Usuario? obterPorId(int id)
    {
        return _usuarioRepository.obterPorId(id);
    }

    public List<Usuario> obterTodos()
    {
        return _usuarioRepository.obterTodos();
    }

    public Boolean atualizar(int id, AtualizarUsuarioRequest request)
    {
        Usuario? usuario = obterPorId(id);
        if (usuario == null) {
            return false;
        }

        usuario.nome = request.nome;
        
        _usuarioRepository.atualizar(usuario);

        return true;

    }
}