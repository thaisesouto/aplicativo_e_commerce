using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class Categoria
    {

        public int IdCategoria { get; set; }

        public String Nome { get; set; }

        public String UrlImagem { get; set; }

        public virtual  IEnumerable<Produto> Produtos { get; set; }
    }
}