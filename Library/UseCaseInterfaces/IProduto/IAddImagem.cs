using CoreBusiness;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Drawing;

namespace Library.UseCaseInterfaces.IProduto
{
    public interface IAddImagem
    {
        void Execute(Produto produto, List<ImagensProdutos> img);
    }
}