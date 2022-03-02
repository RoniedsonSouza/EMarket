using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Quantidade { get; set; }
        [Required]
        public double? Preco { get; set; }
        public bool Destaque { get; set; }
        public string Descricao { get; set; }
        public Category Categoria { get; set; }
        public List<ImagensProdutos> Imagens { get; set; }
    }
}
