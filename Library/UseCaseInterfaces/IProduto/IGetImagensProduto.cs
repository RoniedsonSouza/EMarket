using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IGetImagensProduto
    {
        IEnumerable<ImagensProdutos> Execute(int produtoId);
    }
}