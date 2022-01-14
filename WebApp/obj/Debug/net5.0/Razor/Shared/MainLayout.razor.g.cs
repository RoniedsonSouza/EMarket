#pragma checksum "D:\CODIGOS\Ecommerce\WebApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6b8bcdaaa0436978c3a5e80c181cede4316067"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\CODIGOS\Ecommerce\WebApp\Shared\MainLayout.razor"
   
    var url = NavigationManager.Uri.Split('/');
    var pagina = url[3] == "" ? "Dashboard" : url[3];

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-snfefjgk3b");
            __builder.OpenElement(3, "aside");
            __builder.AddAttribute(4, "class", "sidenav navbar navbar-vertical navbar-expand-xs border-0 border-radius-xl my-3 fixed-start ms-3 ");
            __builder.AddAttribute(5, "data-color", "dark");
            __builder.AddAttribute(6, "id", "sidenav-main");
            __builder.AddAttribute(7, "b-snfefjgk3b");
            __builder.AddMarkupContent(8, @"<div class=""sidenav-header"" b-snfefjgk3b><i class=""fas fa-times p-3 cursor-pointer text-secondary opacity-5 position-absolute end-0 top-0 d-none d-xl-none"" aria-hidden=""true"" id=""iconSidenav"" b-snfefjgk3b></i>
            <a class=""navbar-brand m-0"" href b-snfefjgk3b><span class=""ms-1 font-weight-bold"" b-snfefjgk3b>E-Marketplace</span></a></div>
        ");
            __builder.OpenComponent<WebApp.Shared.NavMenu>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "main main-content position-relative max-height-vh-100 h-100 mt-1 border-radius-lg ps ps--active-y");
            __builder.AddAttribute(13, "b-snfefjgk3b");
            __builder.OpenElement(14, "nav");
            __builder.AddAttribute(15, "class", "navbar navbar-main navbar-expand-lg px-0 mx-4 shadow-none border-radius-xl");
            __builder.AddAttribute(16, "id", "navbarBlur");
            __builder.AddAttribute(17, "navbar-scroll", "true");
            __builder.AddAttribute(18, "b-snfefjgk3b");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container-fluid py-1 px-3");
            __builder.AddAttribute(21, "b-snfefjgk3b");
            __builder.OpenElement(22, "nav");
            __builder.AddAttribute(23, "aria-label", "breadcrumb");
            __builder.AddAttribute(24, "b-snfefjgk3b");
            __builder.OpenElement(25, "ol");
            __builder.AddAttribute(26, "class", "breadcrumb bg-transparent mb-0 pb-0 pt-1 px-0 me-sm-6 me-5");
            __builder.AddAttribute(27, "b-snfefjgk3b");
            __builder.AddMarkupContent(28, "<li class=\"breadcrumb-item text-sm\" b-snfefjgk3b><a class=\"opacity-5 text-dark\" href=\"javascript:;\" b-snfefjgk3b>Página</a></li>\r\n                        ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "breadcrumb-item text-sm text-dark active");
            __builder.AddAttribute(31, "aria-current", "page");
            __builder.AddAttribute(32, "b-snfefjgk3b");
            __builder.AddContent(33, 
#nullable restore
#line 25 "D:\CODIGOS\Ecommerce\WebApp\Shared\MainLayout.razor"
                                                                                                  char.ToUpper(pagina[0])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, 
#nullable restore
#line 25 "D:\CODIGOS\Ecommerce\WebApp\Shared\MainLayout.razor"
                                                                                                                          pagina.Substring(1)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4");
            __builder.AddAttribute(38, "id", "navbar");
            __builder.AddAttribute(39, "b-snfefjgk3b");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "ms-md-auto d-flex align-items-center");
            __builder.AddAttribute(42, "b-snfefjgk3b");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "input-group");
            __builder.AddAttribute(45, "b-snfefjgk3b");
            __builder.OpenComponent<WebApp.Shared.LoginComponent>(46);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "ul");
            __builder.AddAttribute(49, "class", "navbar-nav  justify-content-end");
            __builder.AddAttribute(50, "b-snfefjgk3b");
            __builder.AddMarkupContent(51, @"<li class=""nav-item d-xl-none ps-3 d-flex align-items-center"" b-snfefjgk3b><a href=""javascript:;"" class=""nav-link text-body p-0"" id=""iconNavbarSidenav"" b-snfefjgk3b><div class=""sidenav-toggler-inner"" b-snfefjgk3b><i class=""sidenav-toggler-line"" b-snfefjgk3b></i>
                                    <i class=""sidenav-toggler-line"" b-snfefjgk3b></i>
                                    <i class=""sidenav-toggler-line"" b-snfefjgk3b></i></div></a></li>
                        ");
            __builder.AddMarkupContent(52, @"<li class=""nav-item px-3 d-flex align-items-center"" b-snfefjgk3b><a onclick=""clickConfig()"" class=""nav-link text-body p-0"" b-snfefjgk3b><i class=""fa fa-cog fixed-plugin-button-nav cursor-pointer"" b-snfefjgk3b></i></a></li>
                        
                        

                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
            __builder.AddAttribute(54, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(55, @"<form action=""/Identity/Account/Logout?returnUrl=%2F"" method=""post"" class=""px-2"" b-snfefjgk3b><button id=""sair"" type=""submit"" class=""btn btn-link text-body p-0"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Sair"" b-snfefjgk3b><span class=""fa fa-power-off cursor-pointer"" aria-hidden=""true"" b-snfefjgk3b></span></button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        \r\n\r\n        ");
            __builder.AddMarkupContent(57, "<div class=\"fixed-plugin\" b-snfefjgk3b><a onclick=\"clickConfig()\" class=\"fixed-plugin-button text-dark position-fixed px-3 py-2\" b-snfefjgk3b><i class=\"fa fa-cog py-2\" b-snfefjgk3b></i></a>\r\n            <div class=\"card shadow-lg \" b-snfefjgk3b><div class=\"card-header pb-0 pt-3 \" b-snfefjgk3b><div class=\"float-start\" b-snfefjgk3b><h5 class=\"mt-3 mb-0\" b-snfefjgk3b>Configurações</h5>\r\n                        <p b-snfefjgk3b>Opções do painel.</p></div>\r\n                    <div class=\"float-end mt-3\" b-snfefjgk3b><button onclick=\"clickCloseConfig()\" class=\"btn btn-link text-dark p-2 fixed-plugin-close-button\" b-snfefjgk3b><i class=\"fa fa-close\" b-snfefjgk3b></i></button></div></div>\r\n                <hr class=\"horizontal dark my-1\" b-snfefjgk3b>\r\n                <div class=\"card-body pt-sm-3 pt-0\" b-snfefjgk3b><div b-snfefjgk3b><h6 class=\"mb-0\" b-snfefjgk3b>Cores da barra lateral</h6></div>\r\n                    <a href=\"javascript:void(0)\" class=\"switch-trigger background-color\" b-snfefjgk3b><div class=\"badge-colors my-2 text-start\" b-snfefjgk3b><span class=\"badge filter bg-gradient-primary\" data-color=\"primary\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span>\r\n                            <span class=\"badge filter bg-gradient-dark active\" data-color=\"dark\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span>\r\n                            <span class=\"badge filter bg-gradient-info\" data-color=\"info\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span>\r\n                            <span class=\"badge filter bg-gradient-success\" data-color=\"success\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span>\r\n                            <span class=\"badge filter bg-gradient-warning\" data-color=\"warning\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span>\r\n                            <span class=\"badge filter bg-gradient-danger\" data-color=\"danger\" onclick=\"sidebarColor(this)\" b-snfefjgk3b></span></div></a>\r\n                    \r\n                    <div class=\"mt-3\" b-snfefjgk3b><h6 class=\"mb-0\" b-snfefjgk3b>Tipo da barra lateral</h6>\r\n                        <p class=\"text-sm\" b-snfefjgk3b>Escolha entre 2 tipos diferentes de barras.</p></div>\r\n                    <div class=\"d-flex\" b-snfefjgk3b><button class=\"btn bg-gradient-dark w-100 px-3 mb-2 button-example active\" data-class=\"bg-transparent\" onclick=\"sidebarType(this);\" b-snfefjgk3b>Transparente</button>\r\n                        <button class=\"btn bg-gradient-default w-100 px-3 mb-2 ms-2\" data-class=\"bg-white\" onclick=\"sidebarType(this)\" b-snfefjgk3b>Branco</button></div>\r\n                    <p class=\"text-sm d-xl-none d-block mt-2\" b-snfefjgk3b>Você pode alterar o tipo de sidenav apenas na visualização da área de trabalho.</p>\r\n                    \r\n                    <div class=\"mt-3\" b-snfefjgk3b><h6 class=\"mb-0\" b-snfefjgk3b>Barra de menu fixa</h6></div>\r\n                    <div class=\"form-check form-switch ps-0\" b-snfefjgk3b><input class=\"form-check-input mt-1 ms-auto\" type=\"checkbox\" id=\"navbarFixed\" onclick=\"navbarFixed(this)\" b-snfefjgk3b></div>\r\n                    <hr class=\"horizontal dark my-sm-4\" b-snfefjgk3b></div></div></div>\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "content px-4");
            __builder.AddAttribute(60, "b-snfefjgk3b");
            __builder.AddContent(61, 
#nullable restore
#line 195 "D:\CODIGOS\Ecommerce\WebApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
