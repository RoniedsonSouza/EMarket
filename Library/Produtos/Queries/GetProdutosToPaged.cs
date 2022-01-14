using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Produtos.Queries
{
    public class GetProdutosToPaged : IGetProdutosToPaged
    {
        private readonly IProdutoRepository produtoRepository;

        public GetProdutosToPaged(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IPagedList<Produto> Execute(int page, int qtdPorPage)
        {
            return produtoRepository.GetProdutosToPaged(page, qtdPorPage);
        }
    }
}
