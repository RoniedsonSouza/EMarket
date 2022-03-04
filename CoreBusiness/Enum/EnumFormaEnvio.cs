using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Enum
{
    public enum EnumFormaEnvio
    {
        [Description("Retirar Na Loja")]
        RetirarNaLoja = 1,
        [Description("Receber Compra")]
        Envio = 2,
        [Description("Delivery")]
        Delivery = 3
    }
}
