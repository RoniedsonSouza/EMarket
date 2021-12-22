using CoreBusiness;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IGetProdutoById
    {
        Produto Execute(int produtoId);
    }
}