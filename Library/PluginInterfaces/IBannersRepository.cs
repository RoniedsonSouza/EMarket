using CoreBusiness;
using System.Collections.Generic;

namespace Library.PluginInterfaces
{
    public interface IBannersRepository
    {
        void AddOrRemoveBanners(List<CoreBusiness.Banners> imgs);
        List<CoreBusiness.Banners> GetBanners();
    }
}