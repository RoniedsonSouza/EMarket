# E-Marketplace

Blazor Server back office for a small retail shop: catalog, stock, point of sale, and company profile. The UI is branded **E-Marketplace**. The solution file is `Ecommerce.sln`.

This is an earlier project and it targets **.NET 5**, which is out of support. The code was not upgraded as part of the documentation pass.

It is a staff application, not a customer storefront. There is no public catalog, shopping cart, checkout, or payment gateway.

## Features

What the running application actually does:

- **Sign-in with ASP.NET Core Identity.** Scaffolded Razor Pages cover register, login, logout, email confirmation, forgot password, and account management (email, password, personal data). Accounts live in a separate database (`AccountContext`). Sign-in requires a confirmed account.
- **Authorization by claim.** `Startup` registers two policies: `Admin` (`Position` = `Admin`) and `Caixa` (`Position` = `Caixa`). Every Blazor page in this repo is protected with the `Admin` policy, including the cash register. Nothing in the repository assigns the `Position` claim when a user registers.
- **Dashboard.** Daily and monthly sales totals are calculated from recorded transactions, with a comparison against the previous day and month. The "visits today" and "new customers" cards are static sample numbers in the page, not live metrics.
- **Categories.** Create, edit, delete, and list product categories.
- **Products.** Create, edit, delete, and list products with category, name, stock quantity, price, description, and a highlight flag. Product images are stored with the product (binary content, content type, and a URL). The product list is paged.
- **Banners.** The page titled Logos e Banners uploads and removes images. The picker accepts PNG or JPEG; each file is stored as bytes plus a PNG data URL. The screen keeps at most eight images and reads streams up to 2.5 MB. `EnumTipoBanner` (`Carrossel`, `Footer`) exists on the entity and is not set by this screen. There is no separate logo upload.
- **Cash register.** Pick a product, record a sale against the signed-in user name, decrease stock, and show today's transactions.
- **Transaction history.** Filter sales by cashier name and date range, with a total. A print button calls the browser print dialog (`window.print`).
- **Company profile.** One company record: name, CNPJ, email, phone, mobile, address, city, state, country, and an about text.
- **Toast notifications** through Blazored.Toast.

`CoreBusiness` also contains a `Venda` type and enums for shipping method and sale status. They are not mapped in `MarketContext`, not migrated, and not used by any page.

## Architecture

The solution separates the UI, use cases, and data access. Repositories are registered in `WebApp/Startup.cs`, so the EF Core store can be swapped for another implementation of the same interfaces.

```
Ecommerce.sln
├── WebApp/                 Blazor Server host, Identity UI, Razor pages
├── Library/                Use cases and repository interfaces (PluginInterfaces)
├── Plugins.DataStore/      EF Core SQL Server repositories, MarketContext, migrations
├── DataStore/              In-memory repositories (not the active registration)
└── CoreBusiness/           Entities and enums
```

| Project | Role |
| --- | --- |
| `CoreBusiness` | `Category`, `Produto`, `ImagensProdutos`, `Banners`, `Empresa`, `Transaction`, plus unused sale/shipping types |
| `Library` | One class per use case (`AddProduto`, `VenderProduto`, `GetEstatisticasDashboard`, and so on) behind interfaces in `UseCaseInterfaces`. Data access is only through `PluginInterfaces` |
| `Plugins.DataStore` | `MarketContext` and the repositories the app actually registers. Migrations: initial schema (categories, products, images, company, transactions) and banners |
| `DataStore` | In-memory `ICategoryRepository`, `IProdutoRepository`, and `ITransactionRepository`. The matching `AddScoped` lines in `Startup` are commented out. Several product methods throw `NotImplementedException`. There is no in-memory store for company, dashboard, or banners |
| `WebApp` | Blazor Server (`ServerPrerendered`), Identity hosting startup, and the admin screens. Identity migrations create the ASP.NET Identity tables |

`MarketContext` seeds three categories (Blusa, Calçados, Acessórios) and four sample products.

## Tech stack

Verified from the project files:

- **.NET 5** (`net5.0`) and **Blazor Server**
- **ASP.NET Core Identity** with Entity Framework Core stores (`Microsoft.AspNetCore.Identity.EntityFrameworkCore` / `Identity.UI` 5.0.12)
- **Entity Framework Core 5** with the **SQL Server** provider. Both `DbContext` registrations call `UseSqlServer`
- **PostgreSQL packages are referenced but not wired up.** `WebApp.csproj` includes `Npgsql.EntityFrameworkCore.PostgreSQL` 5.0.10. There is no `UseNpgsql` call. Migrations use SQL Server types (`nvarchar`, `datetime2`, `SqlServer:Identity`). A commented block in `appsettings.json` shows an earlier Heroku-style Postgres configuration; those values are placeholders
- **Two SQL Server databases** by default: `Ecommerce` (shop data) and `Ecommerce_Accounts` (Identity), both with Windows integrated security on `localhost`
- **Docker.** The root `Dockerfile` builds with the .NET 5 SDK image, publishes `WebApp`, and starts it on `http://*:$PORT` (the same shape used for a Heroku container). There is no `docker-compose` file and no database in the image
- **Blazored.Toast** 3.2.2 and **PagedList** 1.17.0
- UI assets include Bootstrap and [Soft UI Dashboard](https://www.creative-tim.com/product/soft-ui-dashboard)

## How to run

You need the **.NET 5 SDK** (install it explicitly; current SDKs do not build `net5.0` projects) and a **SQL Server** instance that matches the connection strings.

1. Restore and build:

   ```bash
   dotnet restore Ecommerce.sln
   dotnet build Ecommerce.sln
   ```

2. Point `WebApp/appsettings.json` at your server if you are not using Windows integrated security on `localhost`. Keep secrets out of the repository (user secrets, environment variables, or an untracked local file).

   The active keys are `ConnectionStrings:DefaultConnection` (`MarketContext`) and `ConnectionStrings:AccountContextConnection` (`AccountContext`).

3. Install the EF Core 5 CLI and apply both migrations:

   ```bash
   dotnet tool install --global dotnet-ef --version 5.0.17
   dotnet ef database update --project Plugins.DataStore --startup-project WebApp --context MarketContext
   dotnet ef database update --project WebApp --startup-project WebApp --context AccountContext
   ```

4. Run the site:

   ```bash
   dotnet run --project WebApp
   ```

   `Properties/launchSettings.json` uses `https://localhost:5001` and `http://localhost:5000` for the `WebApp` profile. Visual Studio also has an IIS Express profile.

5. Create a user at `/Identity/Account/Register`. Before that user can open the app:

   - Set `EmailConfirmed` to true for the user in `Ecommerce_Accounts`. This project does not register an email sender, and Identity's default sender does not deliver mail, so the confirmation link is never sent.
   - Insert a row in `AspNetUserClaims` with `ClaimType` = `Position` and `ClaimValue` = `Admin` for that user id.

   Without that claim the `Admin` policy rejects every Blazor page.

### Docker

The container does not include SQL Server, and the checked-in connection strings use Windows integrated security, which does not work inside the Linux image. Supply connection strings the process can read (for example environment variables `ConnectionStrings__DefaultConnection` and `ConnectionStrings__AccountContextConnection`) and set `PORT`.

```bash
docker build -t emarket .
docker run --rm -e PORT=8080 -p 8080:8080 emarket
```

The runtime stage of the Dockerfile is `mcr.microsoft.com/dotnet/sdk:5.0`, not the ASP.NET runtime image.

## License

Released under the [MIT License](LICENSE). Copyright (c) 2026 Roniedson de Souza Valadares Silva.
