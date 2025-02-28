public interface IUsuarioService
{
    void criar(string name);

    Boolean atualizar(int id, string nome);

    Usuario? obterPorId(int id);
    List<Usuario> obterTodos();
}