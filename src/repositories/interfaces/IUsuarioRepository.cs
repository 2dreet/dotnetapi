namespace MinhaApi.repositories {

    public interface IUsuarioRepository
    {   
        List<Usuario> obterTodos();
        Usuario? obterPorId(int id);

        Usuario? obterPorLogin(string login);

        void criar(Usuario usuario);

        void atualizar(Usuario usuario);

        void remover(Usuario usuario);

        void salvar();
    }
}