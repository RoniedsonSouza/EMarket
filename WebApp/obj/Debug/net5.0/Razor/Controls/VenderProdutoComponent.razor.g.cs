#pragma checksum "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26a4c4ea08cccbc9c95b9b797aede6049797aa5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.ICategory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.IProduto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.ITransactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Library.UseCaseInterfaces.IEmpresa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using WebApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Codigos\EMarket\WebApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class VenderProdutoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
 if (produtoToSell != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
                     produtoToSell

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
                                                   SellProduto

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "<label for=\"name\">Nome do Produto</label>\r\n            ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "id", "name");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "readonly");
                __builder2.AddAttribute(16, "value", 
#nullable restore
#line 11 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
                                                                               produtoToSell.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label for=\"preco\">Preço</label>\r\n            ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "id", "preco");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "readonly");
                __builder2.AddAttribute(26, "value", 
#nullable restore
#line 15 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
                                                                                 string.Format("{0:c}", produtoToSell.Preco)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "<label for=\"quant\">Quantidade</label>\r\n            ");
                __Blazor.WebApp.Controls.VenderProdutoComponent.TypeInference.CreateInputNumber_0(__builder2, 31, 32, "quant", 33, "form-control", 34, 
#nullable restore
#line 19 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
                                                                       produtoToSell.Quantidade

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produtoToSell.Quantidade = __value, produtoToSell.Quantidade)), 36, () => produtoToSell.Quantidade);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.AddMarkupContent(38, "<button type=\"submit\" class=\"btn bg-gradient-info button-align\">Vender</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n    <br>");
#nullable restore
#line 24 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
     if (!string.IsNullOrWhiteSpace(errorMessage))
     {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "alert alert-danger");
#nullable restore
#line 26 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
__builder.AddContent(42, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
      

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Codigos\EMarket\WebApp\Controls\VenderProdutoComponent.razor"
       

    private Produto produtoToSell;
    private string errorMessage;

    [Parameter]
    public string CaixaNome { get; set; }

    [Parameter]
    public Produto SelectedProduto { get; set; }

    [Parameter]
    public EventCallback<Produto> OnProdutoVendido { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (SelectedProduto != null)
        {
            produtoToSell = new Produto
            {
                ProdutoId = SelectedProduto.ProdutoId,
                Name = SelectedProduto.Name,
                CategoryId = SelectedProduto.CategoryId,
                Quantidade = 0,
                Preco = SelectedProduto.Preco
            };
        }
        else
        {
            produtoToSell = null;
        }
    }

    private void SellProduto()
    {

        if (string.IsNullOrWhiteSpace(CaixaNome))
        {
            errorMessage = "É necessario o nome do caixa para a venda do produto.";
            return;
        }

        var produto = GetProdutoById.Execute(produtoToSell.ProdutoId);

        if (produtoToSell.Quantidade <= 0)
        {
            errorMessage = "Quantidade inválida!";
        }
        else if (produto.Quantidade >= produtoToSell.Quantidade)
        {
            OnProdutoVendido.InvokeAsync(produtoToSell);
            errorMessage = string.Empty;
            VenderProduto.Execute(CaixaNome, produtoToSell.ProdutoId, produtoToSell.Name, produtoToSell.Quantidade.Value);
        }
        else
        {
            errorMessage = $"Existem {produto.Quantidade} unidades do produto {produto.Name}. Quantidade de venda insuficiente";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVenderProduto VenderProduto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetProdutoById GetProdutoById { get; set; }
    }
}
namespace __Blazor.WebApp.Controls.VenderProdutoComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
