using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using System.Collections.Generic;

namespace Library.Produtos.Commands
{
    public class EditImagensProduto : IEditImagensProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public EditImagensProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(int prodId, List<ImagensProdutos> img)
        {
            produtoRepository.UpdateImagensProduto(prodId, img);
        }
    }
}
