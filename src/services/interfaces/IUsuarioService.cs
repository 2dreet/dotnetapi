public interface IUsuarioService
{
    void criar(NovoUsuarioRequest request);

    Boolean atualizar(int id, AtualizarUsuarioRequest request);

    Usuario? obterPorId(int id);
    List<Usuario> obterTodos();
}