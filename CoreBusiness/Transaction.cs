using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
   public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime DataTransacao { get; set; }
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QtdAnterior { get; set; }
        public int QuantidadeVendida { get; set; }
        public string NomeCaixa { get; set; }
    }
}
