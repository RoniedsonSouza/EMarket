// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
using CoreBusiness.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
using Library.UseCaseInterfaces.IBanners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Codigos\EMarket\WebApp\Pages\LogosBanners\LogosBannersComponent.razor"
       
    private Banners banners;
    private List<Banners> carrosselBanners;
    private ToastParameters _toastParameters, _toastParametersError, _toastParametersError2, _toastParametersError3;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }


    private async Task OnInputFileChanged(InputFileChangeEventArgs inputFileChangeEventArgs)
    {
        var maxFilesError = false;
        if (inputFileChangeEventArgs.GetMultipleFiles(20).Count > 8)
            maxFilesError = true;
        try
        {
            var fileFormat = "image/png";
            var bannerFile = inputFileChangeEventArgs.GetMultipleFiles();

            foreach (var baner in bannerFile)
            {
                var resizedImageFile = await baner.RequestImageFileAsync(fileFormat, 100, 100);
                var buffer = new byte[baner.Size];
                await baner.OpenReadStream(2500000).ReadAsync(buffer);

                banners = new Banners
                    {
                        DataCadastro = new DateTime(),
                        BannerUrl = $"data:{fileFormat};base64,{Convert.ToBase64String(buffer)}",
                        Banner = buffer
                    };
                carrosselBanners.Add(banners);
            }
        }
        catch
        {
            if (!maxFilesError)
            {
                _toastParametersError2 = new ToastParameters();
                _toastParametersError2.Add(nameof(MyToastComponent.Message), "Não é possivel carregar imagens de tamanho superior a 2.5MB!");
                _toastParametersError2.Add(nameof(MyToastComponent.Type), EnumTipoToast.Error);

                toastService.ShowToast<MyToastComponent>(_toastParametersError2, new ToastInstanceSettings(6, true));
            }
            else
            {
                _toastParametersError3 = new ToastParameters();
                _toastParametersError3.Add(nameof(MyToastComponent.Message), "Selecione no máximo 8 imagens.");
                _toastParametersError3.Add(nameof(MyToastComponent.Type), EnumTipoToast.Error);

                toastService.ShowToast<MyToastComponent>(_toastParametersError3, new ToastInstanceSettings(6, true));
            }
        }
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        carrosselBanners = GetBanners?.Execute();

    }

    protected void RemoveBanner(int bnrIndex)
    {
        carrosselBanners.RemoveAt(bnrIndex);
    }

    private void OnValidSubmit()
    {
        try
        {
            Banners.Execute(carrosselBanners);

            _toastParameters = new ToastParameters();
            _toastParameters.Add(nameof(MyToastComponent.Message), "Banner(s) Salvo(s) Com Sucesso!!");
            _toastParameters.Add(nameof(MyToastComponent.Type), EnumTipoToast.Sucesso);

            toastService.ShowToast<MyToastComponent>(_toastParameters, new ToastInstanceSettings(6, true));

        }
        catch (Exception ex)
        {
            _toastParametersError = new ToastParameters();
            _toastParametersError.Add(nameof(MyToastComponent.Message), "Erro ao Salvar Banner(s)! \n" + ex);
            _toastParametersError.Add(nameof(MyToastComponent.Type), EnumTipoToast.Error);

            toastService.ShowToast<MyToastComponent>(_toastParametersError, new ToastInstanceSettings(6, true));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddOrRemoveBanners Banners { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewBanners ViewBanners { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetBanners GetBanners { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
