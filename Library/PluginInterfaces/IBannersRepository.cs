using CoreBusiness;
using System.Collections.Generic;

namespace Library.PluginInterfaces
{
    public interface IBannersRepository
    {
        void AddBanner(List<CoreBusiness.Banners> imgs);
        List<CoreBusiness.Banners> GetBanners();
        void UpdateBanners(List<CoreBusiness.Banners> imgs);
    }
}