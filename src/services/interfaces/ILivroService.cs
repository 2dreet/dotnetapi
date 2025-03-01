public interface ILivroService
{
    void criar(Usuario usuario, LivroRequest request);
    Livro? atualizar(Usuario usuario, int id, LivroRequest request);
    Livro? obterPorId(Usuario usuario, int id);
    List<Livro> obterTodos(Usuario usuario);
    void deletar(Usuario usuario, int id);
}