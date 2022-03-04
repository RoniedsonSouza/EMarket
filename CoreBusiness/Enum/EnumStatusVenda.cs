using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Enum
{
    public enum EnumStatusVenda
    {
        [Description("Enviado - Encomenda")]
        EnviadoEncomenda = 1,
        [Description("Enviado - Delivery")]
        EnviadoDelivery = 2,
        [Description("Entregue")]
        Entregue = 3,
        [Description("Pendente")]
        Pendente = 4,
        [Description("Em Preparação")]
        Preparacao = 5
    }
}
