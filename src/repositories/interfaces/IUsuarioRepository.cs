namespace MinhaApi.repositories {

    public interface IUsuarioRepository
    {   
        List<Usuario> obterTodos();
        Usuario? obterPorId(int id);

        void criar(Usuario usuario);

        void atualizar(Usuario usuario);

        void remover(int id);

        void salvar();
    }
}