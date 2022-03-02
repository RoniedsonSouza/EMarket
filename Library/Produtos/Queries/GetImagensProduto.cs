using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using System.Collections.Generic;

namespace Library.Produtos.Queries
{
    public class GetImagensProduto : IGetImagensProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public GetImagensProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public IEnumerable<ImagensProdutos> Execute(int produtoId)
        {
            return produtoRepository.GetImagensProduto(produtoId);
        }
    }
}
