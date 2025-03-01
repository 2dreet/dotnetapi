public record UsuarioResult(int Id, string nome){
    public static UsuarioResult mapFrom(Usuario usuario) {
        if (usuario == null) {
            return new UsuarioResult(0, "");
        }

        return new UsuarioResult(usuario.Id, usuario.nome);
    }

    public static List<UsuarioResult> mapFrom(List<Usuario> usuarios) {
        if(usuarios == null) {
            return new List<UsuarioResult>();    
        }

        return usuarios.Select(usuario => new UsuarioResult(usuario.Id, usuario.nome)).ToList();
    }
}