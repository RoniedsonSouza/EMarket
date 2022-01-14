using CoreBusiness;
using PagedList;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IGetProdutosToPaged
    {
        IPagedList<Produto> Execute(int page, int qtdPorPage);
    }
}