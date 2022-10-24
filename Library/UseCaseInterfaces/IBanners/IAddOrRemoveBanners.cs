using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IBanners
{
    public interface IAddOrRemoveBanners
    {
        void Execute(List<CoreBusiness.Banners> banners);
    }
}