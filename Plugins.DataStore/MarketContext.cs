using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<ImagensProdutos> ImagensProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Produto>()
                .HasMany(c => c.Imagens)
                .WithOne(p => p.Produto)
                .HasForeignKey(p => p.ProdutoId);


            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Blusa", Description = "Blusa" },
                    new Category { CategoryId = 2, Name = "Calçados", Description = "Calçados" },
                    new Category { CategoryId = 3, Name = "Acessórios", Description = "Acessórios" }
                );

            modelBuilder.Entity<Produto>().HasData(
                    new Produto { ProdutoId = 1, CategoryId = 1, Name = "Produto Teste", Quantidade = 50, Preco = 100, Destaque = false, Descricao = "" },
                    new Produto { ProdutoId = 2, CategoryId = 1, Name = "Short", Quantidade = 10, Preco = 5.99, Destaque = false, Descricao = "" },
                    new Produto { ProdutoId = 3, CategoryId = 1, Name = "Camisa", Quantidade = 8, Preco = 59.99, Destaque = false, Descricao = "" },
                    new Produto { ProdutoId = 4, CategoryId = 2, Name = "Corta Vento", Quantidade = 100, Preco = 3.99, Destaque = false, Descricao = "" }
                );
        }
    }
}
