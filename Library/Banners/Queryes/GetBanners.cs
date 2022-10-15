using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IBanners;
using Library.UseCaseInterfaces.ICategory;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Banners.Queryes
{
    public class GetBanners : IGetBanners
    {
        private readonly IBannersRepository bannerRepository;

        public GetBanners(IBannersRepository bannerRepository)
        {
            this.bannerRepository = bannerRepository;
        }

        public List<CoreBusiness.Banners> Execute()
        {
            return bannerRepository.GetBanners();
        }
    }
}
