# E-Commerce Catalog API

API RESTful desenvolvida em .NET 9 para gerenciamento de catálogo de produtos de um e-commerce. Projeto construído aplicando princípios de Clean Architecture, DDD simplificado e boas práticas (SOLID).

## Tecnologias e Arquitetura

* **Framework:** .NET 9 (C#)
* **Banco de Dados:** PostgreSQL (via Docker)
* **ORM** Entity Framework Core 9 (Code-First)
* **Testes:** xUnit + Moq
* **Documentação:** Swagger / OpenAPI
* **Arquitetura:** Divisão em 4 camadas (Domain, Infrastructure, Application e API). Padrão Repository e DI.

## Como rodar o projeto localmente

**Pré-requisitos:** .NET 9 SDK e Docker Desktop instalados.

1. Clone o repositório.
2. Na raiz do projeto, suba o banco de dados usando o Docker compose.

   docker compose up -d

3. O banco será criado automaticamente na porta 5432. As tabelas serão geradas via Migrations ao iniciar a API ou manualmente com:

    dotnet ef database update --project ECommerceCatalog.Infrastructure --startup-project ECommerceCatalog.API

4. Inicie a aplicação:

    dotnet run --project ECommerceCatalog.API

5. Acesse a documentação e teste os endpoints no navegador:

    https://localhost:5001/swagger (a porta pode ser diferente - verifique o console - )

## Rodando os Testes

Para executar os testes unitarios de regra de negócio (Services):

    dotnet test

---

