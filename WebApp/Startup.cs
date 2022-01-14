using Library.Categoria;
using Library.Categoria.Commands;
using Library.Categoria.Queries;
using Library.Empresa;
using Library.Empresa.Commands;
using Library.Empresa.Queries;
using Library.PluginInterfaces;
using Library.Produtos;
using Library.Produtos.Commands;
using Library.Produtos.Queries;
using Library.Transacoes;
using Library.UseCaseInterfaces.ICategory;
using Library.UseCaseInterfaces.IEmpresa;
using Library.UseCaseInterfaces.IProduto;
using Library.UseCaseInterfaces.ITransactions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plugins.DataStore;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<MarketContext>(options => 
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", p => p.RequireClaim("Position", "Admin"));
                options.AddPolicy("Caixa", p => p.RequireClaim("Position", "Caixa"));
            });

            //Dependecy Injection dentro da memoria para testes
            //services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
            //services.AddScoped<IProdutoRepository, ProdutoInMemoryRepository>();
            //services.AddScoped<ITransactionRepository, TransactionInMemoryRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();

            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategory, EditCategory>();
            services.AddTransient<IGetCategoryById, GetCategoryById>();
            services.AddTransient<IDeleteCategory, DeleteCategory>();
            services.AddTransient<IViewProdutos, ViewProdutos>();
            services.AddTransient<IAddProduto, AddProduto>();
            services.AddTransient<IEditProduto, EditProduto>();
            services.AddTransient<IGetProdutoById, GetProdutoById>();
            services.AddTransient<IDeleteProduto, DeleteProduto>();
            services.AddTransient<IViewProdutosByCategoryId, ViewProdutosByCategoryId>();
            services.AddTransient<IVenderProduto, VenderProduto>();
            services.AddTransient<IHistoryTransactions, HistoryTransactions>();
            services.AddTransient<IGetTodayTransactions, GetTodayTransactions>();
            services.AddTransient<IGetTransactions, GetTransactions>();
            services.AddTransient<IAddEmpresa, AddEmpresa>();
            services.AddTransient<IEditEmpresa, EditEmpresa>();
            services.AddTransient<IGetEmpresaById, GetEmpresaById>();
            services.AddTransient<IViewEmpresa, ViewEmpresa>();
            services.AddTransient<IGetCategories, GetCategories>();
            services.AddTransient<IGetProdutosToPaged, GetProdutosToPaged>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
