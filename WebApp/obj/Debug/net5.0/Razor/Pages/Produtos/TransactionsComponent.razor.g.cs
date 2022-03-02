#pragma checksum "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd4ff1e9a8d163857c61f532d16e7bf6d079166"
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
#line 2 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transacoes")]
    public partial class TransactionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Transações</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-3");
            __builder.AddMarkupContent(6, "<label for=\"caixa\">Nome do Caixa</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "id", "caixa");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                            caixaNome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => caixaNome = __value, caixaNome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-3");
            __builder.AddMarkupContent(16, "<label for=\"dataInicial\">Data da Transação</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "date");
            __builder.AddAttribute(19, "id", "dataInicial");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                  data

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => data = __value, data, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-3");
            __builder.AddMarkupContent(26, "<label for=\"dataFinal\">Até</label>\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "date");
            __builder.AddAttribute(29, "id", "dataFinal");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                dataFinal

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataFinal = __value, dataFinal, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-xl-3");
            __builder.AddAttribute(36, "style", "display: flex; align-items: end;");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "display: inline-block;");
            __builder.AddMarkupContent(39, "<label>&nbsp;</label>\r\n                ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn bg-gradient-info");
            __builder.AddAttribute(43, "style", "margin-bottom: 0;");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                                       LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Pesquisar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "display: inline-block;");
            __builder.AddMarkupContent(49, "<label>&nbsp;</label>\r\n                ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn bg-gradient-warning");
            __builder.AddAttribute(53, "style", "margin-bottom: 0;");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                                                                                                          ImprimirRelatorio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"fa fa-print\">&nbsp;&nbsp;</i>\r\n                    Imprimir\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n<br>");
#nullable restore
#line 40 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "id", "imprimirArea");
            __builder.OpenElement(59, "table");
            __builder.AddAttribute(60, "class", "table table-bordered text-center");
            __builder.AddMarkupContent(61, @"<thead><tr><th>Dt da Venda</th>
                    <th>Caixa</th>
                    <th>Produto</th>
                    <th>Qtd Anterior</th>
                    <th>Qtd Vendida</th>
                    <th>Qtd Atual</th>
                    <th>Valor da Venda</th></tr></thead>
            ");
            __builder.OpenElement(62, "tbody");
#nullable restore
#line 56 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                 foreach (var tran in transactions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "tr");
            __builder.OpenElement(64, "td");
#nullable restore
#line 59 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(65, tran.DataTransacao.ToString("g"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "td");
#nullable restore
#line 60 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(68, tran.NomeCaixa);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "td");
#nullable restore
#line 61 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(71, tran.NomeProduto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "td");
#nullable restore
#line 62 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(74, tran.QtdAnterior);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "td");
#nullable restore
#line 63 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(77, tran.QuantidadeVendida);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "td");
#nullable restore
#line 64 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(80, tran.QtdAnterior - tran.QuantidadeVendida);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "td");
#nullable restore
#line 65 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(83, string.Format("{0:c}", tran.QuantidadeVendida * tran.Preco));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "tfoot");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "<td colspan=\"5\">&nbsp;</td>\r\n                    ");
            __builder.AddMarkupContent(88, "<td><b>Total</b></td>\r\n                    ");
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "b");
#nullable restore
#line 75 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
__builder.AddContent(91, string.Format("{0:c}", transactions.Sum(x => x.Preco * x.QuantidadeVendida)));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "D:\CODIGOS\Ecommerce\WebApp\Pages\Produtos\TransactionsComponent.razor"
       

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
