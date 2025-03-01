namespace MinhaApi.repositories {
    public interface ILivroRepository
    {
        List<Livro> obterTodos(Usuario usuario);
        Livro? obterPorId(Usuario usuario, int id);
        void criar(Livro livro);
        void atualizar(Livro livro);
        void remover(Livro livro);
        void salvar();
    }

}