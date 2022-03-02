using CoreBusiness;
using PagedList;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IGetProdutosToPaged
    {
        IPagedList<Produto> Execute(int? page, int qtdPorPage);
        IEnumerable<Produto> ExecuteResult();
    }
}