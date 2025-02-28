
# Minha API - Projeto em .NET

Este projeto é uma API RESTful simples desenvolvida em .NET, utilizando o ASP.NET Core. A API permite criar e recuperar usuários com dados básicos (nome e CPF). Também possui suporte para documentação e testes com o Swagger.

## Como rodar o projeto

### 1. Pré-requisitos

Antes de rodar o projeto, você precisa ter os seguintes pré-requisitos instalados:

- [SDK .NET 6.0 ou superior](https://dotnet.microsoft.com/download)
- [Visual Studio Code ou outra IDE de sua escolha](https://code.visualstudio.com/)
- [Postman ou ferramenta similar para testar as rotas (opcional)](https://www.postman.com/)

### 2. Rodando o projeto

#### Passo 1: Clonar o repositório

Clone este repositório para sua máquina local:

```bash
git clone https://github.com/2dreet/dotnetapi.git
```

#### Passo 2: Navegar até o diretório do projeto

Acesse a pasta do projeto onde o arquivo `.csproj` está localizado:

```bash
cd MinhaApi
```

#### Passo 3: Restaurar dependências

Restaure as dependências do projeto utilizando o comando `dotnet restore`:

```bash
dotnet restore
```

#### Passo 4: Rodar o projeto

Para rodar a API, use o seguinte comando:

```bash
dotnet run
```

Isso vai compilar e iniciar o servidor. Você verá um log no terminal informando que o servidor está rodando, normalmente na URL `http://localhost:5007` (ou outra porta, dependendo da configuração).

---

## Rodando com Hot Reload

O **Hot Reload** permite que você veja as mudanças no código sem precisar reiniciar o servidor manualmente. Para rodar o projeto com **Hot Reload**, siga os passos abaixo:

1. Abra o terminal na pasta do projeto.
2. Execute o comando abaixo para rodar o projeto com suporte a Hot Reload:

```bash
dotnet watch run
```

Agora, sempre que você modificar o código, o servidor será atualizado automaticamente e refletirá as mudanças sem precisar reiniciar o servidor manualmente.

---

## Acessando a api

Para acessar a API:

1. Inicie o servidor utilizando o comando `dotnet run` ou `dotnet watch run`.
2. Abra o seu navegador e acesse a seguinte URL:

```bash
http://localhost:5007/api/
```

---

## Acessando a Documentação com Swagger

O Swagger foi configurado para fornecer uma interface gráfica que documenta todas as rotas da API. Para acessá-lo:

1. Inicie o servidor utilizando o comando `dotnet run` ou `dotnet watch run`.
2. Abra o seu navegador e acesse a seguinte URL:

```bash
http://localhost:5007/swagger
```

Isso irá abrir a interface do Swagger, onde você pode visualizar todas as rotas disponíveis, suas descrições e fazer testes diretamente pela interface gráfica.

### URLs disponíveis no Swagger:

- **GET /api/usuario**: Retorna a lista de usuários.
- **GET /api/usuario/{id}**: Recupera um usuário pelo ID.
- **POST /api/usuario**: Cria um novo usuário.
- **PUT /api/usuario/{id}**: Atualiza um usuário pelo ID.

No Swagger, você pode testar essas rotas e visualizar a resposta diretamente na interface.


---

## Contribuições

Sinta-se à vontade para fazer contribuições! Caso queira adicionar funcionalidades ou corrigir erros, por favor, crie um *pull request* com suas alterações.

---

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).