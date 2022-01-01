#pragma checksum "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbdde4f83b621d4bc0c486a559284c7b41f912e9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.Empresa
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
#line 2 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empresa")]
    public partial class EmpresaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Empresa</h3>\r\n<br>");
#nullable restore
#line 10 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
 if (empresa == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                            OnClickAddEmpresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Cadastrar");
            __builder.CloseElement();
#nullable restore
#line 13 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card mt-2");
            __builder.AddMarkupContent(8, "<div class=\"card-header\">Informações Básicas</div>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-6");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"name\">Nome</label>\r\n                    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "id", "name");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "disabled");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 21 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                                                       empresa?.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-6");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "<label for=\"cnpj\">CNPJ</label>\r\n                    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "id", "cnpj");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 27 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                         empresa?.CNPJ

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "disabled");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-6");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "<label for=\"tel\">Telefone</label>\r\n                    ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "id", "tel");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 35 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                        empresa?.Telefone

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "disabled");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-6");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddMarkupContent(55, "<label for=\"cel\">Celular</label>\r\n                    ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "id", "cel");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "value", 
#nullable restore
#line 41 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                        empresa?.Celular

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "disabled");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n<br>\r\n");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card");
            __builder.AddMarkupContent(65, "<div class=\"card-header\">Endereço</div>\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card-body");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-6");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.AddMarkupContent(74, "<label for=\"end\">Endereço</label>\r\n                    ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "id", "end");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "value", 
#nullable restore
#line 55 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                        empresa?.Endereco

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(79, "disabled");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-6");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "form-group");
            __builder.AddMarkupContent(86, "<label for=\"cidade\">Cidade</label>\r\n                    ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "id", "cidade");
            __builder.AddAttribute(89, "type", "text");
            __builder.AddAttribute(90, "value", 
#nullable restore
#line 61 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                           empresa?.Cidade

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(91, "disabled");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "row");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-6");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "form-group");
            __builder.AddMarkupContent(100, "<label for=\"estado\">Estado</label>\r\n                    ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "id", "estado");
            __builder.AddAttribute(103, "type", "text");
            __builder.AddAttribute(104, "value", 
#nullable restore
#line 69 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                           empresa?.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(105, "disabled");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-6");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group");
            __builder.AddMarkupContent(112, "<label for=\"pais\">País</label>\r\n                    ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "id", "pais");
            __builder.AddAttribute(115, "type", "text");
            __builder.AddAttribute(116, "value", 
#nullable restore
#line 75 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                         empresa?.Pais

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(117, "disabled");
            __builder.AddAttribute(118, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n<br>\r\n");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "card");
            __builder.AddMarkupContent(122, "<div class=\"card-header\">Informações Adicionais</div>\r\n    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "card-body");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "form-group");
            __builder.AddMarkupContent(127, "<label for=\"sobre\">Sobre</label>\r\n            ");
            __builder.OpenElement(128, "textarea");
            __builder.AddAttribute(129, "id", "sobre");
            __builder.AddAttribute(130, "type", "text");
            __builder.AddAttribute(131, "value", 
#nullable restore
#line 87 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                     empresa?.Sobre

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(132, "disabled");
            __builder.AddAttribute(133, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n<br>");
#nullable restore
#line 92 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
 if (empresa != null)
 {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "type", "button");
            __builder.AddAttribute(137, "class", "btn btn-info button-align");
            __builder.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
                                                                        () => OnEditEmpresa(empresa)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(139, "Editar");
            __builder.CloseElement();
#nullable restore
#line 95 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
 }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(140, "<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\EmpresaComponent.razor"
       
    private CoreBusiness.Empresa empresa;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        var empr = GetEmpresaById.Execute(1);
        if (empr != null)
        {
            this.empresa = new Empresa
            {
                EmpresaId = empr.EmpresaId,
                Nome = empr.Nome,
                CNPJ = empr.CNPJ,
                Telefone = empr.Telefone,
                Celular = empr.Celular,
                Endereco = empr.Endereco,
                Cidade = empr.Cidade,
                Estado = empr.Estado,
                Pais = empr.Pais,
                Sobre = empr.Sobre
            };
        }

    }

    private void OnClickAddEmpresa()
    {
        NavigationManager.NavigateTo("/adicionar-empresa");
    }

    private void OnEditEmpresa(Empresa empresa)
    {
        NavigationManager.NavigateTo($"/editar-empresa/{empresa.EmpresaId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetEmpresaById GetEmpresaById { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewEmpresa ViewEmpresa { get; set; }
    }
}
#pragma warning restore 1591