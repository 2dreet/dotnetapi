
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

    public void atualizar(Usuario usuario, AtualizarUsuarioRequest request)
    {
        usuario.nome = request.nome;
        
        _usuarioRepository.atualizar(usuario);
    }

    public Usuario? obterPorLogin(string login)
    {
        return _usuarioRepository.obterPorLogin(login);
    }

    public void deletar(Usuario usuario)
    {
        _usuarioRepository.remover(usuario);
    }

    public Usuario? login(LoginRequest request)
    {
        Usuario? usuario = obterPorLogin(request.login);

        if(usuario == null) {
            return null;
        }

        if (usuario.senha != request.senha) {
            return null;
        }

        return usuario;
    }
}