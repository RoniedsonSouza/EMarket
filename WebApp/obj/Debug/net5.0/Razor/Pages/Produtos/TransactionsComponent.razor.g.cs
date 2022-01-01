#pragma checksum "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44dc80a2bab8b823990fc35cb06ad07fad63c74"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class TransactionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3");
            __builder.AddMarkupContent(5, "<label for=\"caixa\">Nome do Caixa</label>\r\n            ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "id", "caixa");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                            caixaNome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caixaNome = __value, caixaNome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-3");
            __builder.AddMarkupContent(15, "<label for=\"dataInicial\">Data da Transação</label>\r\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "date");
            __builder.AddAttribute(18, "id", "dataInicial");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                  data

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => data = __value, data, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-3");
            __builder.AddMarkupContent(25, "<label for=\"dataFinal\">Até</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "date");
            __builder.AddAttribute(28, "id", "dataFinal");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                dataFinal

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataFinal = __value, dataFinal, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-2");
            __builder.AddMarkupContent(35, "<label>&nbsp;</label>\r\n            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-primary form-control");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                 LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Pesquisar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddMarkupContent(43, "<label>&nbsp;</label>\r\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary form-control");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                 ImprimirRelatorio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Imprimir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n<br>");
#nullable restore
#line 33 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "id", "imprimirArea");
            __builder.OpenElement(52, "table");
            __builder.AddAttribute(53, "class", "table table-bordered text-center");
            __builder.AddMarkupContent(54, @"<thead><tr><th>Dt da Venda</th>
                    <th>Caixa</th>
                    <th>Produto</th>
                    <th>Qtd Anterior</th>
                    <th>Qtd Vendida</th>
                    <th>Qtd Atual</th>
                    <th>Valor da Venda</th></tr></thead>
            ");
            __builder.OpenElement(55, "tbody");
#nullable restore
#line 49 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                 foreach (var tran in transactions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "tr");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 52 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             tran.DataTransacao.ToString("g")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 53 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             tran.NomeCaixa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 54 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             tran.NomeProduto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 55 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             tran.QtdAnterior

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 56 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             tran.QuantidadeVendida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 57 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                              tran.QtdAnterior - tran.QuantidadeVendida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 58 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                              string.Format("{0:c}", tran.QuantidadeVendida * tran.Preco)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "tfoot");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "<td colspan=\"5\">&nbsp;</td>\r\n                    ");
            __builder.AddMarkupContent(81, "<td><b>Total</b></td>\r\n                    ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "b");
            __builder.AddContent(84, 
#nullable restore
#line 68 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                             string.Format("{0:c}", transactions.Sum(x => x.Preco * x.QuantidadeVendida))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
       

    private string caixaNome;
    private DateTime data;
    private DateTime dataFinal;
    private IEnumerable<Transaction> transactions;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        data = DateTime.Today;
        dataFinal = DateTime.Today;
    }

    private void LoadTransactions()
    {
        transactions = GetTransactions.Execute(caixaNome, data, dataFinal);
    }

    private void ImprimirRelatorio()
    {
        JSRuntime.InvokeVoidAsync("print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTransactions GetTransactions { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591