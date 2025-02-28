using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();

// Adiciona o serviço de Controllers
builder.Services.AddControllers(); // Adiciona o serviço de Controllers

// Adiciona o serviço de geração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Minha API",
        Version = "v1",
        Description = "API para gerenciar usuários"
    });
});

var app = builder.Build();

// Ativa o Swagger no pipeline de requisições
app.UseSwagger(); // Gera a documentação do Swagger
app.UseSwaggerUI(); // Interface do Swagger

// Mapeia os controllers
app.MapControllers(); // Agora o ASP.NET Core pode mapear as rotas automaticamente

app.Run();

