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

        public void AddBanner(List<Banners> imgs)
        {
            if (imgs != null)
            {
                foreach (var banner in imgs)
                {
                    context.Banners.Add(new Banners
                    {
                        Banner = banner.Banner,
                        BannerUrl = banner.BannerUrl,
                        ContentType = banner.ContentType,
                        Tipo = banner.Tipo
                    });
                    context.SaveChanges();
                }
            }
        }

        public List<Banners> GetBanners()
        {
            return context.Banners?.ToList();
        }

        public void UpdateBanners(List<Banners> imgs)
        {
            var banners = context.Banners.ToList();

            var includedBanners = imgs.Except(banners).ToList();
            var excludedBanners = banners.Except(imgs).ToList();

            context.Banners.RemoveRange(excludedBanners);
            context.SaveChanges();
            context.Banners.AddRange(includedBanners);
            context.SaveChanges();
        }
    }
}
