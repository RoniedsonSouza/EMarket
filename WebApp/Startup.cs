using DataStore;
using Library.Categoria;
using Library.Categoria.Commands;
using Library.Categoria.Queries;
using Library.DataStorePluginInterfaces;
using Library.PluginInterfaces;
using Library.Produtos;
using Library.Produtos.Commands;
using Library.Produtos.Queries;
using Library.UseCaseInterfaces.ICategory;
using Library.UseCaseInterfaces.IProduto;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApp.Data;

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
            services.AddSingleton<WeatherForecastService>();

            services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
            services.AddScoped<IProdutoRepository, ProdutoInMemoryRepository>();

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
