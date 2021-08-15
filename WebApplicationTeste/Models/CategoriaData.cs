using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTeste.Models
{
    public class CategoriaData
    {
        //public CategoriaData()
        //{
        //    Produto = new HashSet<Produto>();
        //}

        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime? DataCriacao { get; set; }

       //public ICollection<Produto> Produto { get; set; }
    }
}
