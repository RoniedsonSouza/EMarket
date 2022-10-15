using CoreBusiness.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Banners : DTOPattern
    {
        [Key]
        public int BannerID { get; set; }
        public byte[] Banner { get; set; }
        public string BannerUrl { get; set; }
        public string ContentType { get; set; }
        public EnumTipoBanner Tipo { get; set; }
    }
}
