using System;
using System.Collections.Generic;

namespace ApiTeste.Models
{
    public partial class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int Quantidade { get; set; }
        public int IdCategoria { get; set; }

        public Categoria IdCategoriaNavigation { get; set; }
    }
}
