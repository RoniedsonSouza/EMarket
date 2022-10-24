#pragma checksum "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3323e32b6b963ca93e9f268f26bd1db6ad2264e"
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
#nullable restore
#line 2 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-empresa/{EmpresaId}")]
    public partial class EditEmpresaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Empresa</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                 empresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card mt-2");
                __builder2.AddMarkupContent(11, "<div class=\"card-header\">Informações Básicas</div>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "card-body");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-6");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label for=\"name\">Nome</label>\r\n                        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "id", "name");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
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
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-6");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"cnpj\">CNPJ</label>\r\n                        ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "id", "cnpj");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
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
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-6");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label for=\"tel\">Telefone</label>\r\n                        ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "id", "tel");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
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
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-6");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "<label for=\"cel\">Celular</label>\r\n                        ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "id", "cel");
                __builder2.AddAttribute(61, "type", "text");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
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
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "row");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-6");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "<label for=\"email\">Email</label>\r\n                        ");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "id", "email");
                __builder2.AddAttribute(75, "type", "text");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                   empresa.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Email = __value, empresa.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "card");
                __builder2.AddMarkupContent(82, "<div class=\"card-header\">Endereço</div>\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "card-body");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "row");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-6");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "<label for=\"end\">Endereço</label>\r\n                        ");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "id", "end");
                __builder2.AddAttribute(94, "type", "text");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                 empresa.Endereco

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Endereco = __value, empresa.Endereco));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-6");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddMarkupContent(103, "<label for=\"cidade\">Cidade</label>\r\n                        ");
                __builder2.OpenElement(104, "input");
                __builder2.AddAttribute(105, "id", "cidade");
                __builder2.AddAttribute(106, "type", "text");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                    empresa.Cidade

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Cidade = __value, empresa.Cidade));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "row");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "col-6");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "<label for=\"estado\">Estado</label>\r\n                        ");
                __builder2.OpenElement(118, "input");
                __builder2.AddAttribute(119, "id", "estado");
                __builder2.AddAttribute(120, "type", "text");
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                    empresa.Estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Estado = __value, empresa.Estado));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-6");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-group");
                __builder2.AddMarkupContent(129, "<label for=\"pais\">País</label>\r\n                        ");
                __builder2.OpenElement(130, "input");
                __builder2.AddAttribute(131, "id", "pais");
                __builder2.AddAttribute(132, "type", "text");
                __builder2.AddAttribute(133, "class", "form-control");
                __builder2.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                  empresa.Pais

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Pais = __value, empresa.Pais));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "card");
                __builder2.AddMarkupContent(139, "<div class=\"card-header\">Informações Adicionais</div>\r\n        ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "card-body");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group");
                __builder2.AddMarkupContent(144, "<label for=\"sobre\">Sobre</label>\r\n                ");
                __builder2.OpenElement(145, "input");
                __builder2.AddAttribute(146, "id", "sobre");
                __builder2.AddAttribute(147, "type", "text");
                __builder2.AddAttribute(148, "class", "form-control");
                __builder2.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                           empresa.Sobre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empresa.Sobre = __value, empresa.Sobre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(152, "div");
                __builder2.AddAttribute(153, "class", "button-align-2");
                __builder2.AddMarkupContent(154, "<button type=\"submit\" class=\"btn bg-gradient-info\">Salvar</button>\r\n        ");
                __builder2.OpenElement(155, "button");
                __builder2.AddAttribute(156, "type", "button");
                __builder2.AddAttribute(157, "class", "btn btn-gradient-danger");
                __builder2.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
                                                                        OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(159, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(160, "\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Codigos\EMarket\WebApp\Pages\Empresa\EditEmpresaComponent.razor"
       
    [Parameter]
    public string EmpresaId { get; set; }

    private Empresa empresa;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (int.TryParse(this.EmpresaId, out int iEmpresaId))
        {
            var empr = GetEmpresaById.Execute(iEmpresaId);
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
                Sobre = empr.Sobre,
                Email = empr.Email
            };
        }
    }

    private void OnValidSubmit()
    {
        EditEmpresa.Execute(this.empresa);
        NavigationManager.NavigateTo("/empresa");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/empresa");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditEmpresa EditEmpresa { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetEmpresaById GetEmpresaById { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewEmpresa ViewEmpresa { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
