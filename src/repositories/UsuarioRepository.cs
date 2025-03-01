
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
            return _context.Usuarios.Find(id);
        }

        public List<Usuario> obterTodos()
        {
            return _context.Usuarios.ToList();
        }

        public void remover(int id)
        {
            Usuario? usuario = obterPorId(id);
            if (usuario == null) {
                return;
            }

            _context.Usuarios.Remove(usuario);
            salvar();
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }

}