
using MinhaApi.Data;

namespace MinhaApi.repositories
{
    public class LivroRepository : ILivroRepository
    {

        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }
        public void atualizar(Livro livro)
        {
            _context.Livros.Update(livro);
            salvar();
        }

        public void criar(Livro livro)
        {
            _context.Livros.Add(livro);
            salvar();
        }

        public Livro? obterPorId(Usuario usuario, int id)
        {
            return _context.Livros.Where(livro => livro.usuario.Id == usuario.Id && livro.Id == id ).FirstOrDefault();
        }

        public List<Livro> obterTodos(Usuario usuario)
        {
            return _context.Livros.Where(livro => livro.usuario.Id == usuario.Id).ToList();
        }

        public void remover(Livro livro)
        {
            _context.Livros.Remove(livro);
            salvar();
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}