using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IViewProdutosByCategoryId
    {
        IEnumerable<Produto> Execute(int categoryId);
    }
}