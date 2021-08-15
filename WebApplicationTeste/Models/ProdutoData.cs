using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTeste.Models
{
    public class ProdutoData
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int Quantidade { get; set; }
        public int IdCategoria { get; set; }
    }
}
