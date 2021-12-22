using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IViewProdutos
    {
        IEnumerable<Produto> Execute();
    }
}