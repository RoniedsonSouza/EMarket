# E-Marketplace

Painel administrativo em Blazor Server para uma loja: catálogo, estoque, caixa e dados da empresa. É um projeto antigo em **.NET 5**, fora de suporte.

## Funcionalidades

- Autenticação com ASP.NET Core Identity, em banco separado
- Categorias, produtos com imagens e banners
- Caixa, baixa de estoque e histórico de vendas
- Painel de vendas do dia e do mês
- Cadastro da empresa

## Stack

.NET 5, Blazor Server, ASP.NET Core Identity, Entity Framework Core 5 e SQL Server (`Ecommerce` e `Ecommerce_Accounts`). O pacote Npgsql está referenciado, mas o código usa apenas `UseSqlServer`. O `Dockerfile` publica a aplicação e a sobe em `http://*:$PORT`.

## Como rodar

É necessário o SDK do .NET 5 e um SQL Server compatível com `WebApp/appsettings.json`.

```bash
dotnet tool install --global dotnet-ef --version 5.0.17
dotnet ef database update --project Plugins.DataStore --startup-project WebApp --context MarketContext
dotnet ef database update --project WebApp --startup-project WebApp --context AccountContext
dotnet run --project WebApp
```

O perfil local abre `https://localhost:5001`. Depois do cadastro em `/Identity/Account/Register`, marque `EmailConfirmed` e grave a claim `Position` = `Admin` em `AspNetUserClaims`. O projeto não envia e-mail de confirmação.

## Limitações

- Não há vitrine, carrinho nem pagamento. O acesso às telas exige a política `Admin`.
- O .NET 5 está fora de suporte. O Postgres não está ligado em tempo de execução, e os repositórios em memória não estão registrados.
- No painel, acessos e novos clientes são números fixos. Os tipos de venda e envio em `CoreBusiness` não são usados.

## Licença

[MIT](LICENSE). Direitos autorais (c) 2026 Roniedson de Souza Valadares Silva.
