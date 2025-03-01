using MinhaApi.repositories;

public static class RepositoryRegistration
{   
    public static void AddApplicationRepository(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        // Registre outras implementações de repositório de forma simples aqui
    }
    
}