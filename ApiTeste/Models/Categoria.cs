using System;
using System.Collections.Generic;

namespace ApiTeste.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produto = new HashSet<Produto>();
        }

        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime? DataCriacao { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
