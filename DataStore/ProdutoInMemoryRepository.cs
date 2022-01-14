using CoreBusiness;
using Library.PluginInterfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class ProdutoInMemoryRepository : IProdutoRepository
    {
        private List<Produto> produtos;
        public ProdutoInMemoryRepository()
        {
            produtos = new List<Produto>()
            {
                new Produto { ProdutoId = 1, CategoryId = 1, Name = "Produto", Quantidade = 50, Preco = 100},
                new Produto { ProdutoId = 2, CategoryId = 1, Name = "Short", Quantidade = 10, Preco = 5.99},
                new Produto { ProdutoId = 3, CategoryId = 1, Name = "Camisa", Quantidade = 8, Preco = 59.99},
                new Produto { ProdutoId = 4, CategoryId = 2, Name = "Corta Vento", Quantidade = 100, Preco = 3.99}
            };
        }

        public void AddProduto(Produto produto)
        {
            if (produtos.Any(x => x.Name.Equals(produto.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (produtos != null && produtos.Count > 0)
            {
                var maxId = produtos.Max(x => x.CategoryId);
                produto.CategoryId = maxId + 1;
            }
            else
            {
                produto.CategoryId = 1;
            }

            produtos.Add(produto);
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return produtos;
        }

        public void UpdateProduto(Produto produto)
        {
            var produtoToUpdate = GetProdutoById(produto.ProdutoId);
            if (produtoToUpdate != null)
            {
                produtoToUpdate.Name = produto.Name;
                produtoToUpdate.CategoryId = produto.CategoryId;
                produtoToUpdate.Quantidade = produto.Quantidade;
                produtoToUpdate.Preco = produto.Preco;
            }
        }

        public Produto GetProdutoById(int produtoId)
        {
            return produtos.FirstOrDefault(x => x.ProdutoId == produtoId);
        }

        public void DeleteProduto(int produtoId)
        {
            var produtoToDelete = GetProdutoById(produtoId);
            if (produtoToDelete != null) produtos.Remove(produtoToDelete);
        }

        public IEnumerable<Produto> GetProdutosByCategoryId(int categoryId)
        {
            return produtos.Where(x => x.CategoryId == categoryId);
        }

        public IPagedList<Produto> GetProdutosToPaged(int page, int qtdPorPage)
        {
            throw new NotImplementedException();
        }
    }
}
