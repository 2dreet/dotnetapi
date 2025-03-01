using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

public static class SercurityServiceRegistration
{
    public static void AddSecurityJwtServices(this IServiceCollection services, IConfiguration _config)
    {   

        var keyString = _config["Jwt:Key"] ?? throw new ArgumentNullException("Jwt:Key não pode ser nulo");

        var key = Encoding.UTF8.GetBytes(keyString);

        // Registro dos serviços
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _config["Jwt:Issuer"],
                ValidAudience = _config["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        });
    }
}