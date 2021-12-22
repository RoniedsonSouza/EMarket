using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;

namespace Library.Produtos.Commands
{
    public class AddProduto : IAddProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public AddProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(Produto produto)
        {
            produtoRepository.AddProduto(produto);
        }
    }
}
