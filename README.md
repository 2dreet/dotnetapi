# 📌 Minha API com .NET e SQLite

Este projeto é uma API RESTful desenvolvida em **.NET** usando **Entity Framework Core** com **SQLite** como banco de dados.

---

## 🚀 Como Rodar o Projeto

### **1️⃣ Clonar o Repositório**
```bash
git clone https://github.com/seu-repositorio.git
cd MeuProjeto
```

### **2️⃣ Instalar Dependências**
```bash
dotnet restore
```

### **3️⃣ Configurar o Banco de Dados SQLite**
Instale a ferramenta CLI do Entity Framework (caso ainda não tenha):
```bash
dotnet tool install --global dotnet-ef
```
Se já tiver instalado, atualize:
```bash
dotnet tool update --global dotnet-ef
```

Agora, instale os pacotes necessários:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

```

### **4️⃣ Criar e Aplicar Migrações**
Gerar a migração inicial:
```bash
dotnet ef migrations add InitialCreate
```

Aplicar a migração ao banco de dados:
```bash
dotnet ef database update
```

---

## 🛠️ **Rodando a API**
Para iniciar o servidor da API, execute:
```bash
dotnet run
```

A API estará disponível em:  
📍 **http://localhost:5000** (ou outra porta definida no `appsettings.json`)

---

## 🔄 **Rodar no Modo Hot Refresh**
Para que a API reinicie automaticamente ao salvar arquivos:
```bash
dotnet watch run
```

---

## 📖 **Acessar Swagger (Documentação da API)**
O Swagger UI estará disponível em:
📌 **http://localhost:5000/swagger**

Isso permitirá testar endpoints diretamente no navegador.

---

## 🛠️ **Principais Comandos Úteis**
| Comando | Descrição |
|---------|-------------|
| `dotnet restore` | Restaura as dependências do projeto |
| `dotnet build` | Compila o código-fonte |
| `dotnet run` | Executa a aplicação |
| `dotnet watch run` | Executa com hot reload |
| `dotnet ef migrations add NomeMigracao` | Cria uma nova migração |
| `dotnet ef database update` | Aplica as migrações ao banco |

---

## 💡 **Conclusão**
Agora você tem uma API funcional usando **.NET** + **SQLite**! 🚀 Se tiver dúvidas, me avise!

