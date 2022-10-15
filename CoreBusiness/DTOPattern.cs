using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class DTOPattern
    {
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public bool Deletado { get; set; }
    }
}
