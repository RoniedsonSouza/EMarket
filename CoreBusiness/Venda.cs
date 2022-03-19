using CoreBusiness.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public DateTime Data_Venda { get; set; }
        public DateTime Previsao_Entrega { get; set; }
        public int ProdutoId { get; set; }
        public EnumFormaEnvio Forma_Envio { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor_Frete { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor_Venda { get; set; }
        public EnumStatusVenda Status { get; set; }
        public string Endereco { get; set; }
    }
}
