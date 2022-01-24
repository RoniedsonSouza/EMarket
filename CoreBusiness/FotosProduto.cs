using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class FotosProduto
    {
        [Key]
        public int FotoID { get; set; }
        public string Imagem { get; set; }
        public List<Produto> Produto { get; set; }
    }
}
