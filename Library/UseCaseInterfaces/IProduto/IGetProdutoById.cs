using CoreBusiness;
using System;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IGetProdutoById
    {
        Produto Execute(int produtoId);
    }
}