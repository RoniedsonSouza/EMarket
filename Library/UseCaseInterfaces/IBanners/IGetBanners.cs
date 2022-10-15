using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IBanners
{
    public interface IGetBanners
    {
        List<CoreBusiness.Banners> Execute();
    }
}