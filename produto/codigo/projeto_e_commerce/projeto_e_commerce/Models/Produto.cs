using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class Produto
    {
        public int IdProduto { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Double Preco { get; set; }

        public String UrlImagem { get; set; }

        public Categoria Categoria { get; set; }

    }
}