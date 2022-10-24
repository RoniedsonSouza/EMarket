using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IBanners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Banners.Commands
{
    public class AddOrRemoveBanners : IAddOrRemoveBanners
    {
        private readonly IBannersRepository bannersRepository;

        public AddOrRemoveBanners(IBannersRepository bannersRepository)
        {
            this.bannersRepository = bannersRepository;
        }

        public void Execute(List<CoreBusiness.Banners> banners)
        {
            bannersRepository.AddOrRemoveBanners(banners);
        }
    }
}
