
using MinhaApi.repositories;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository _livroRepository)
    {
        this._livroRepository = _livroRepository;
    }
    public Livro? atualizar(Usuario usuario, int id, LivroRequest request)
    {
        Livro? livro = obterPorId(usuario, id);
        
        if (livro == null) {
            return null;
        }

        livro.updateValuesFrom(request);

        _livroRepository.atualizar(livro);

        return livro;
    }

    public void criar(Usuario usuario, LivroRequest request)
    {
        _livroRepository.criar(new Livro(request.nome, request.descricao,usuario));
    }

    public void deletar(Usuario usuario, int id)
    {

    }

    public Livro? obterPorId(Usuario usuario, int id)
    {
        return _livroRepository.obterPorId(usuario, id);
    }

    public List<Livro> obterTodos(Usuario usuario)
    {
        return _livroRepository.obterTodos(usuario);
    }
}