using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;

namespace Library.Produtos.Queries
{
    public class GetProdutoById : IGetProdutoById
    {
        private readonly IProdutoRepository produtoRepository;

        public GetProdutoById(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public Produto Execute(int produtoId)
        {
            return produtoRepository.GetProdutoById(produtoId);
        }
    }
}
