// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages.Produtos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.ICategory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.IProduto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.ITransactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.IEmpresa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CODIGOS\Ecommerce\WebApp\_Imports.razor"
using WebApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\AddProdutoComponent.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\AddProdutoComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\AddProdutoComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produtos/NovoProduto")]
    public partial class AddProdutoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\AddProdutoComponent.razor"
       

    private Produto produto;
    private ImagensProdutos imagem;
    private List<ImagensProdutos> imagens;
    private Image img;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        imagens = new List<ImagensProdutos>();
        imagem = new ImagensProdutos();
        produto = new Produto();
        categories = ViewCategories.Execute();
    }

    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEventArgs)
    {
        var fileFormat = "image/png";
        var imageFile = inputFileChangeEventArgs.GetMultipleFiles();

        foreach (var image in imageFile)
        {
            var resizedImageFile = await image.RequestImageFileAsync(fileFormat, 100, 100);
            var buffer = new byte[image.Size];
            await image.OpenReadStream().ReadAsync(buffer);

            imagem = new ImagensProdutos
                {
                    ImageUrl = $"data:{fileFormat};base64,{Convert.ToBase64String(buffer)}",
                    Imagem = buffer
                };

            imagens.Add(imagem);
        }
    }

    protected void RemoveImagem(int imgIndex)
    {
        imagens.RemoveAt(imgIndex);
    }

    private void OnValidSubmit()
    {
        IAddProduto.Execute(produto);
        IAddImagem.Execute(produto, imagens);
        NavigationManager.NavigateTo("/produtos/1");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/produtos/1");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewCategoriesUseCase ViewCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetCategoryById GetCategoryById { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddImagem IAddImagem { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddProduto IAddProduto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
