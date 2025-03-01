
using MinhaApi.Data;

namespace MinhaApi.repositories {

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public void atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            salvar();
        }

        public void criar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            salvar();
        }

        public Usuario? obterPorId(int id)
        {
            return _context.Usuarios.Where(usuario => usuario.Id == id).FirstOrDefault();
        }

        public Usuario? obterPorLogin(string login)
        {
            return _context.Usuarios.Where(usuario => usuario.login == login).FirstOrDefault();
        }

        public List<Usuario> obterTodos()
        {
            return _context.Usuarios.ToList();
        }

        public void remover(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            salvar();
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }

}