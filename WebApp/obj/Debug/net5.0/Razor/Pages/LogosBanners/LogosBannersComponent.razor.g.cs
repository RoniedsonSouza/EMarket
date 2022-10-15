#pragma checksum "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e11415d9aaeb548f22695c923aa62482d29846b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.LogosBanners
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
#line 2 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
using Library.UseCaseInterfaces.IBanners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logos-banners")]
    public partial class LogosBannersComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Logos e Banners</h3>\r\n<br>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
                 carrosselBanners

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
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
                __builder2.AddAttribute(10, "class", "col-sm-12");
                __builder2.AddMarkupContent(11, "<label for=\"banners\">Banners</label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "id", "gridBanners");
                __builder2.AddAttribute(14, "class", "form-group");
#nullable restore
#line 29 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
             foreach (var img in carrosselBanners.Select((value, index) => new { value, index }))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "card-body");
                __builder2.AddAttribute(19, "style", "padding:0;");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "style", "letter-spacing:0rem;");
                __builder2.AddAttribute(22, "class", "btn-remove-img text-dark");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
                                                                                                     () => RemoveBanner(img.index)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "title", "Excluir Banner");
                __builder2.AddMarkupContent(25, "<span class=\"fa fa-times\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenElement(27, "img");
                __builder2.AddAttribute(28, "class", "imgsBanner");
                __builder2.AddAttribute(29, "src", 
#nullable restore
#line 36 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
                                                      img.value.BannerUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(30, "multiple");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "card custom-file text-center");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(33);
                __builder2.AddAttribute(34, "id", "banners");
                __builder2.AddAttribute(35, "class", "custom-file-input");
                __builder2.AddAttribute(36, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
                                                                             OnInputFileChanged

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.AddMarkupContent(39, "<div class=\"card-body\"><i class=\"fa fa-plus fa-3x\" aria-hidden=\"true\"></i>\r\n                    <div class=\"card-footer\">Adicionar Banner</div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
       
    private Banners banners;
    private List<Banners> carrosselBanners;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }


    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEventArgs)
    {
        var fileFormat = "image/png";
        var bannerFile = inputFileChangeEventArgs.GetMultipleFiles();

        foreach (var baner in bannerFile)
        {
            var resizedImageFile = await baner.RequestImageFileAsync(fileFormat, 100, 100);
            var buffer = new byte[baner.Size];
            await baner.OpenReadStream().ReadAsync(buffer);

            banners = new Banners
                {
                    BannerUrl = $"data:{fileFormat};base64,{Convert.ToBase64String(buffer)}",
                    Banner = buffer
                };

            carrosselBanners.Add(banners);
        }
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        carrosselBanners = GetBanners.Execute();

    }

    protected void RemoveBanner(int bnrIndex)
    {
        carrosselBanners.RemoveAt(bnrIndex);
    }

    private void OnValidSubmit()
    {
        NavigationManager.NavigateTo("/logos-banners");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewBanners ViewBanners { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetBanners GetBanners { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
