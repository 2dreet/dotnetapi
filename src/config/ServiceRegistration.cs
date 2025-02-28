public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services)
    {
        // Registro dos serviços
        services.AddScoped<IUsuarioService, UsuarioService>();
    }
}