public record LivroResult(int Id, string nome, string descricao){
    public static LivroResult mapFrom(Livro livro) {
        if (livro == null) {
            return new LivroResult(0, "", "");
        }

        return new LivroResult(livro.Id, livro.nome, livro.descricao);
    }

    public static List<LivroResult> mapFrom(List<Livro> livros) {
        if(livros == null) {
            return new List<LivroResult>();    
        }

        return livros.Select(livro => new LivroResult(livro.Id, livro.nome, livro.descricao)).ToList();
    }
}