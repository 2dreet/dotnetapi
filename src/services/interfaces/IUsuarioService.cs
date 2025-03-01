public interface IUsuarioService
{
    void criar(NovoUsuarioRequest request);

    void atualizar(Usuario usuario, AtualizarUsuarioRequest request);

    Usuario? obterPorId(int id);
    List<Usuario> obterTodos();

    Usuario? obterPorLogin(string login);

    void deletar(Usuario usuario);

    Usuario? login(LoginRequest request);
}