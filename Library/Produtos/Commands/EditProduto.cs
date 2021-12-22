using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;

namespace Library.Produtos.Commands
{
    public class EditProduto : IEditProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public EditProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(Produto produto)
        {
            produtoRepository.UpdateProduto(produto);
        }
    }
}
