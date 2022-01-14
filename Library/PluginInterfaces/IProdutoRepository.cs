using CoreBusiness;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.PluginInterfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetProdutos();
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        void DeleteProduto(int produtoId);
        IEnumerable<Produto> GetProdutosByCategoryId(int categoryId);
        Produto GetProdutoById(int produtoId);
        IPagedList<Produto> GetProdutosToPaged(int page, int qtdPorPage);
    }
}
