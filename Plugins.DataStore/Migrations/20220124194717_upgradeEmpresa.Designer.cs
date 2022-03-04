﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore;

namespace Plugins.DataStore.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20220124194717_upgradeEmpresa")]
    partial class upgradeEmpresa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Blusa",
                            Name = "Blusa"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Calçados",
                            Name = "Calçados"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Acessórios",
                            Name = "Acessórios"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("CoreBusiness.FotosProduto", b =>
                {
                    b.Property<int>("FotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FotoID");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("CoreBusiness.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Destaque")
                        .HasColumnType("bit");

                    b.Property<int?>("FotoID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Preco")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quantidade")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FotoID");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CategoryId = 1,
                            Descricao = "",
                            Destaque = false,
                            Name = "Produto Teste",
                            Preco = 100.0,
                            Quantidade = 50
                        },
                        new
                        {
                            ProdutoId = 2,
                            CategoryId = 1,
                            Descricao = "",
                            Destaque = false,
                            Name = "Short",
                            Preco = 5.9900000000000002,
                            Quantidade = 10
                        },
                        new
                        {
                            ProdutoId = 3,
                            CategoryId = 1,
                            Descricao = "",
                            Destaque = false,
                            Name = "Camisa",
                            Preco = 59.990000000000002,
                            Quantidade = 8
                        },
                        new
                        {
                            ProdutoId = 4,
                            CategoryId = 2,
                            Descricao = "",
                            Destaque = false,
                            Name = "Corta Vento",
                            Preco = 3.9900000000000002,
                            Quantidade = 100
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataTransacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeCaixa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QtdAnterior")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeVendida")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Produto", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreBusiness.FotosProduto", "Foto_Do_Produto")
                        .WithMany("Produto")
                        .HasForeignKey("FotoID");

                    b.Navigation("Categoria");

                    b.Navigation("Foto_Do_Produto");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CoreBusiness.FotosProduto", b =>
                {
                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}