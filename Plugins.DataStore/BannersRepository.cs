using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.PluginInterfaces;

namespace Plugins.DataStore
{
    public class BannersRepository : IBannersRepository
    {
        private readonly MarketContext context;

        public BannersRepository(MarketContext context)
        {
            this.context = context;
        }

        public void AddOrRemoveBanners(List<Banners> imgs)
        {
            var banners = context.Banners?.ToList();

            var includedBanners = imgs?.Except(banners).ToList();
            var excludedBanners = banners?.Except(imgs).ToList();

            if (imgs != null)
            {
                if (excludedBanners.Count != 0)
                {
                    context.Banners.RemoveRange(excludedBanners);
                    context.SaveChanges();
                }
                else if (includedBanners.Count != 0)
                {
                    context.Banners.AddRange(includedBanners);
                    context.SaveChanges();
                }
            }
        }

        public List<Banners> GetBanners()
        {
            return context.Banners?.ToList();
        }
    }
}
