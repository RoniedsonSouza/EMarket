using CoreBusiness;
using Library.PluginInterfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MarketContext context;

        public ProdutoRepository(MarketContext context)
        {
            this.context = context;
        }
        public void AddProduto(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public void DeleteProduto(int produtoId)
        {
            var product = context.Produtos.Find(produtoId);
            if (product == null) return;

            context.Produtos.Remove(product);
            context.SaveChanges();
        }

        public Produto GetProdutoById(int produtoId)
        {
            return context.Produtos.Find(produtoId);
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return context.Produtos.ToList();
        }

        public IPagedList<Produto> GetProdutosToPaged(int page, int qtdPorPage)
        {
            return context.Produtos.ToPagedList(page, qtdPorPage);
        }

        public IEnumerable<Produto> GetProdutosByCategoryId(int categoryId)
        {
            return context.Produtos.Where(x => x.CategoryId == categoryId).ToList();
        }

        public void UpdateProduto(Produto produto)
        {
            var prod = context.Produtos.Find(produto.ProdutoId);
            prod.CategoryId = produto.CategoryId;
            prod.Name = produto.Name;
            prod.Preco = produto.Preco;
            prod.Quantidade = produto.Quantidade;
            prod.Destaque = produto.Destaque;
            prod.Descricao = produto.Descricao;
            prod.Foto_Do_Produto = produto.Foto_Do_Produto;

            context.SaveChanges();
        }
    }
}
