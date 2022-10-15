using CoreBusiness;
using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IBanners
{
    public interface IViewBanners
    {
        List<CoreBusiness.Banners> Execute();
    }
}