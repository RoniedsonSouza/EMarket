using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IEditImagensProduto
    {
        void Execute(int prodId, List<ImagensProdutos> img);
    }
}