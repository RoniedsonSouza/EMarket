using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Produtos
{
    public class ViewProdutos : IViewProdutos
    {
        private readonly IProdutoRepository produtoRepository;

        public ViewProdutos(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public IEnumerable<Produto> Execute()
        {
            return produtoRepository.GetProdutos();
        }
    }
}
