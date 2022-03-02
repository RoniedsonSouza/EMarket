using CoreBusiness;
using Microsoft.AspNetCore.Http;
using PagedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.PluginInterfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetProdutos();
        IEnumerable<ImagensProdutos> GetImagensProduto(int produtoId);
        void AddProduto(Produto produto);
        void AddImagem(Produto produto, List<ImagensProdutos> img);
        void UpdateProduto(Produto produto);
        void UpdateImagensProduto(int prodId, List<ImagensProdutos> img);
        void DeleteProduto(int produtoId);
        IEnumerable<Produto> GetProdutosByCategoryId(int categoryId);
        Produto GetProdutoById(int produtoId);
        IPagedList<Produto> GetProdutosToPaged(int? page, int qtdPorPage);
    }
}
