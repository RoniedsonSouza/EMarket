#pragma checksum "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3e269d5d914e225f017fad77c6ded0b7ac6745"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr class=\"horizontal dark mt-0\" b-c2wpa7m53j>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "collapse navbar-collapse  w-auto  max-height-vh-100 h-100");
            __builder.AddAttribute(3, "id", "sidenav-collapse-main");
            __builder.AddAttribute(4, "b-c2wpa7m53j");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "navbar-nav");
            __builder.AddAttribute(7, "b-c2wpa7m53j");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "nav-item");
            __builder.AddAttribute(10, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "class", "nav-link");
            __builder.AddAttribute(13, "href", "");
            __builder.AddAttribute(14, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-sitemap small\" b-c2wpa7m53j></span></div>\r\n                ");
                __builder2.AddMarkupContent(17, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Dashboard</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "nav-item");
            __builder.AddAttribute(21, "data-toggle", "collapse");
            __builder.AddAttribute(22, "data-target", "#collapseSite");
            __builder.AddAttribute(23, "aria-expanded", "false");
            __builder.AddAttribute(24, "aria-controls", "collapseSite");
            __builder.AddAttribute(25, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-code small\" b-c2wpa7m53j></span></div>\r\n                ");
                __builder2.AddMarkupContent(31, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Site</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "nav-item subnav collapse");
            __builder.AddAttribute(35, "id", "collapseSite");
            __builder.AddAttribute(36, "b-c2wpa7m53j");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "navbar-nav");
            __builder.AddAttribute(39, "b-c2wpa7m53j");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "nav-item");
            __builder.AddAttribute(42, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "logos-banners/");
            __builder.AddAttribute(46, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
                                                                           NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-picture-o small\" b-c2wpa7m53j></span></div>\r\n                        ");
                __builder2.AddMarkupContent(49, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Logos & Banners</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "nav-item");
            __builder.AddAttribute(53, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddAttribute(56, "href", "categorias/");
            __builder.AddAttribute(57, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 34 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
                                                                        NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-stream small\" b-c2wpa7m53j></span></div>\r\n                        ");
                __builder2.AddMarkupContent(60, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Categorias</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "li");
            __builder.AddAttribute(63, "class", "nav-item");
            __builder.AddAttribute(64, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
            __builder.AddAttribute(66, "class", "nav-link");
            __builder.AddAttribute(67, "href", "produtos/");
            __builder.AddAttribute(68, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 42 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
                                                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-tags small\" b-c2wpa7m53j></span></div>\r\n                        ");
                __builder2.AddMarkupContent(71, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Produtos</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "li");
            __builder.AddAttribute(74, "class", "nav-item");
            __builder.AddAttribute(75, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
            __builder.AddAttribute(77, "class", "nav-link");
            __builder.AddAttribute(78, "href", "caixa_console");
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(80, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><svg width=\"12px\" height=\"12px\" viewBox=\"0 0 42 42\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" b-c2wpa7m53j><title b-c2wpa7m53j>box-3d-50</title>\r\n                        <g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\" b-c2wpa7m53j><g transform=\"translate(-2319.000000, -291.000000)\" fill=\"#FFFFFF\" fill-rule=\"nonzero\" b-c2wpa7m53j><g transform=\"translate(1716.000000, 291.000000)\" b-c2wpa7m53j><g transform=\"translate(603.000000, 0.000000)\" b-c2wpa7m53j><path class=\"color-background\" d=\"M22.7597136,19.3090182 L38.8987031,11.2395234 C39.3926816,10.9925342 39.592906,10.3918611 39.3459167,9.89788265 C39.249157,9.70436312 39.0922432,9.5474453 38.8987261,9.45068056 L20.2741875,0.1378125 L20.2741875,0.1378125 C19.905375,-0.04725 19.469625,-0.04725 19.0995,0.1378125 L3.1011696,8.13815822 C2.60720568,8.38517662 2.40701679,8.98586148 2.6540352,9.4798254 C2.75080129,9.67332903 2.90771305,9.83023153 3.10122239,9.9269862 L21.8652864,19.3090182 C22.1468139,19.4497819 22.4781861,19.4497819 22.7597136,19.3090182 Z\" b-c2wpa7m53j></path>\r\n                                        <path class=\"color-background opacity-6\" d=\"M23.625,22.429159 L23.625,39.8805372 C23.625,40.4328219 24.0727153,40.8805372 24.625,40.8805372 C24.7802551,40.8805372 24.9333778,40.8443874 25.0722402,40.7749511 L41.2741875,32.673375 L41.2741875,32.673375 C41.719125,32.4515625 42,31.9974375 42,31.5 L42,14.241659 C42,13.6893742 41.5522847,13.241659 41,13.241659 C40.8447549,13.241659 40.6916418,13.2778041 40.5527864,13.3472318 L24.1777864,21.5347318 C23.8390024,21.7041238 23.625,22.0503869 23.625,22.429159 Z\" b-c2wpa7m53j></path>\r\n                                        <path class=\"color-background opacity-6\" d=\"M20.4472136,21.5347318 L1.4472136,12.0347318 C0.953235098,11.7877425 0.352562058,11.9879669 0.105572809,12.4819454 C0.0361450918,12.6208008 6.47121774e-16,12.7739139 0,12.929159 L0,30.1875 L0,30.1875 C0,30.6849375 0.280875,31.1390625 0.7258125,31.3621875 L19.5528096,40.7750766 C20.0467945,41.0220531 20.6474623,40.8218132 20.8944388,40.3278283 C20.963859,40.1889789 21,40.0358742 21,39.8806379 L21,22.429159 C21,22.0503869 20.7859976,21.7041238 20.4472136,21.5347318 Z\" b-c2wpa7m53j></path></g></g></g></g></svg></div>\r\n                ");
                __builder2.AddMarkupContent(81, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Console Caixa</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "li");
            __builder.AddAttribute(84, "class", "nav-item");
            __builder.AddAttribute(85, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
            __builder.AddAttribute(87, "class", "nav-link");
            __builder.AddAttribute(88, "href", "transacoes");
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(90, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-exchange-alt small\" b-c2wpa7m53j></span></div>\r\n                ");
                __builder2.AddMarkupContent(91, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Transações</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item");
            __builder.AddAttribute(95, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(96);
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "empresa");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><span class=\"fa fa-building small\" b-c2wpa7m53j></span></div>\r\n                ");
                __builder2.AddMarkupContent(101, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Empresa</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.AddMarkupContent(103, "<li class=\"nav-item mt-3\" b-c2wpa7m53j><h6 class=\"ps-4 ms-2 text-uppercase text-xs font-weight-bolder opacity-6\" b-c2wpa7m53j>Conta</h6></li>\r\n        ");
            __builder.OpenElement(104, "li");
            __builder.AddAttribute(105, "class", "nav-item");
            __builder.AddAttribute(106, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(107);
            __builder.AddAttribute(108, "class", "nav-link");
            __builder.AddAttribute(109, "href", "Perfil");
            __builder.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(111, "<div class=\"icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center\" b-c2wpa7m53j><svg width=\"12px\" height=\"12px\" viewBox=\"0 0 46 42\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" b-c2wpa7m53j><title b-c2wpa7m53j>customer-support</title>\r\n                        <g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\" b-c2wpa7m53j><g transform=\"translate(-1717.000000, -291.000000)\" fill=\"#FFFFFF\" fill-rule=\"nonzero\" b-c2wpa7m53j><g transform=\"translate(1716.000000, 291.000000)\" b-c2wpa7m53j><g transform=\"translate(1.000000, 0.000000)\" b-c2wpa7m53j><path class=\"color-background opacity-6\" d=\"M45,0 L26,0 C25.447,0 25,0.447 25,1 L25,20 C25,20.379 25.214,20.725 25.553,20.895 C25.694,20.965 25.848,21 26,21 C26.212,21 26.424,20.933 26.6,20.8 L34.333,15 L45,15 C45.553,15 46,14.553 46,14 L46,1 C46,0.447 45.553,0 45,0 Z\" b-c2wpa7m53j></path>\r\n                                        <path class=\"color-background\" d=\"M22.883,32.86 C20.761,32.012 17.324,31 13,31 C8.676,31 5.239,32.012 3.116,32.86 C1.224,33.619 0,35.438 0,37.494 L0,41 C0,41.553 0.447,42 1,42 L25,42 C25.553,42 26,41.553 26,41 L26,37.494 C26,35.438 24.776,33.619 22.883,32.86 Z\" b-c2wpa7m53j></path>\r\n                                        <path class=\"color-background\" d=\"M13,28 C17.432,28 21,22.529 21,18 C21,13.589 17.411,10 13,10 C8.589,10 5,13.589 5,18 C5,22.529 8.568,28 13,28 Z\" b-c2wpa7m53j></path></g></g></g></g></svg></div>\r\n                ");
                __builder2.AddMarkupContent(112, "<span class=\"nav-link-text ms-1\" b-c2wpa7m53j>Perfil</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "li");
            __builder.AddAttribute(115, "class", "nav-item");
            __builder.AddAttribute(116, "b-c2wpa7m53j");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(117);
            __builder.AddAttribute(118, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(119, @"<form action=""/Identity/Account/Logout?returnUrl=%2F"" method=""post"" b-c2wpa7m53j><button type=""submit"" class=""btn btn-link nav-link"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Sair"" style=""width: 86%;transform: none;text-transform: none;"" b-c2wpa7m53j><div class=""icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center"" b-c2wpa7m53j><span class=""fa fa-sign-out-alt small"" b-c2wpa7m53j></span></div>
                            <span class=""cursor-pointer"" aria-hidden=""true"" b-c2wpa7m53j>Sair</span></button></form>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Codigos\EMarket\WebApp\Shared\NavMenu.razor"
       
    [Parameter]
    public int PageNumber { get; set; } = 1;

    private string RoteRedirect(string rote)
    {
        var url = Navigation.Uri.Split('/');
        url[3] = "";
        PageNumber = 1;
        var chamada = url[3] + rote + "/" + PageNumber.ToString();
        return chamada;

        //JsRuntime.InvokeVoidAsync("console.log", rote);
    }

    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
