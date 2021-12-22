using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Produtos.Commands
{
    public class VenderProduto : IVenderProduto
    {
        private readonly IProdutoRepository produtoRepository;
        public VenderProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public void Execute(int produtoId, int QtdVendida)
        {
            var produto = produtoRepository.GetProdutoById(produtoId);
            if (produto == null) return;

            produto.Quantidade -= QtdVendida;
            produtoRepository.UpdateProduto(produto);
        }
    }
}
