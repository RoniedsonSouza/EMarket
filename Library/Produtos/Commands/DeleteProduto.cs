using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;

namespace Library.Produtos.Commands
{
    public class DeleteProduto : IDeleteProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public DeleteProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(int produtoId)
        {
            produtoRepository.DeleteProduto(produtoId);
        }
    }
}
