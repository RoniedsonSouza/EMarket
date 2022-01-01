#pragma checksum "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5bba6905845539c55baf66adb1e83bb3ae0a217"
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
#line 2 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adicionar-empresa")]
    public partial class AddEmpresaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Empresa</h3>");
#nullable restore
#line 9 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
 if (empresa != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                     empresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                             OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card mt-2");
                __builder2.AddMarkupContent(11, "<div class=\"card-header\">Informações Básicas</div>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "card-body");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-6");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label for=\"name\">Nome</label>\r\n                            ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "id", "name");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                                           empresa.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Nome = __value, empresa.Nome));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-6");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"cnpj\">CNPJ</label>\r\n                            ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "id", "cnpj");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                      empresa.CNPJ

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.CNPJ = __value, empresa.CNPJ));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-6");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label for=\"tel\">Telefone</label>\r\n                            ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "id", "tel");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                     empresa.Telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Telefone = __value, empresa.Telefone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-6");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "<label for=\"cel\">Celular</label>\r\n                            ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "id", "cel");
                __builder2.AddAttribute(61, "type", "text");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                     empresa.Celular

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Celular = __value, empresa.Celular));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "card");
                __builder2.AddMarkupContent(68, "<div class=\"card-header\">Endereço</div>\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "card-body");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "row");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-6");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "<label for=\"end\">Endereço</label>\r\n                            ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "id", "end");
                __builder2.AddAttribute(80, "type", "text");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                     empresa.Endereco

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Endereco = __value, empresa.Endereco));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-6");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "<label for=\"cidade\">Cidade</label>\r\n                            ");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "id", "cidade");
                __builder2.AddAttribute(92, "type", "text");
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                        empresa.Cidade

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Cidade = __value, empresa.Cidade));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "row");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-6");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddMarkupContent(103, "<label for=\"estado\">Estado</label>\r\n                            ");
                __builder2.OpenElement(104, "input");
                __builder2.AddAttribute(105, "id", "estado");
                __builder2.AddAttribute(106, "type", "text");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                        empresa.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Estado = __value, empresa.Estado));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "col-6");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddMarkupContent(115, "<label for=\"pais\">País</label>\r\n                            ");
                __builder2.OpenElement(116, "input");
                __builder2.AddAttribute(117, "id", "pais");
                __builder2.AddAttribute(118, "type", "text");
                __builder2.AddAttribute(119, "class", "form-control");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                                      empresa.Pais

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Pais = __value, empresa.Pais));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "card");
                __builder2.AddMarkupContent(125, "<div class=\"card-header\">Informações Adicionais</div>\r\n            ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "card-body");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-group");
                __builder2.AddMarkupContent(130, "<label for=\"sobre\">Sobre</label>\r\n                    ");
                __builder2.OpenElement(131, "input");
                __builder2.AddAttribute(132, "id", "sobre");
                __builder2.AddAttribute(133, "type", "text");
                __builder2.AddAttribute(134, "class", "form-control");
                __builder2.AddAttribute(135, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                               empresa.Sobre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Sobre = __value, empresa.Sobre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(138, "<button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n        ");
                __builder2.OpenElement(139, "button");
                __builder2.AddAttribute(140, "type", "button");
                __builder2.AddAttribute(141, "class", "btn btn-danger");
                __builder2.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
                                                               OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(143, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n    <br>");
#nullable restore
#line 96 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\CODIGOS\Ecommerce\WebApp\Pages\Empresa\AddEmpresaComponent.razor"
       

    private Empresa empresa;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        empresa = new Empresa();
    }

    private void OnValidSubmit()
    {
        AddEmpresa.Execute(empresa);
        NavigationManager.NavigateTo("/empresa");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/empresa");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddEmpresa AddEmpresa { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
