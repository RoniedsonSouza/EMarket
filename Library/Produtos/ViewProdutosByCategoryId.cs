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
    public class ViewProdutosByCategoryId : IViewProdutosByCategoryId
    {
        private readonly IProdutoRepository produtoRepository;

        public ViewProdutosByCategoryId(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public IEnumerable<Produto> Execute(int categoryId)
        {
            return produtoRepository.GetProdutosByCategoryId(categoryId);
        }
    }
}
