using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IBanners;
using Library.UseCaseInterfaces.ICategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Categoria
{
    public class ViewBanners : IViewBanners
    {
        private readonly IBannersRepository bannersRepository;

        public ViewBanners(IBannersRepository bannersRepository)
        {
            this.bannersRepository = bannersRepository;
        }
        public List<CoreBusiness.Banners> Execute()
        {
            return bannersRepository.GetBanners();
        }
    }
}
