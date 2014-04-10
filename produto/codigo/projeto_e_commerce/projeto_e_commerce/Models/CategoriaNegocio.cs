using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class Categoria
    {
        public Categoria GetCategoria(int id)
        {
            var rtn = ListaCategoria().FirstOrDefault(n => n.IdCategoria == id);

            rtn.Produtos = new Produto().getProdutos().Where(n => n.Categoria.IdCategoria == rtn.IdCategoria);

            return rtn;
        }


        public List<Categoria> ListaCategoria()
        {
            return new List<Categoria>
                       {
                           new Categoria {IdCategoria = 1, Nome = "Padaria", UrlImagem = "../../Content/images/padaria.jpg"},
                           new Categoria {IdCategoria = 2, Nome = "Carnes", UrlImagem = "../../Content/images/carnes.jpg"},
                           new Categoria {IdCategoria = 3, Nome = "hortifrutigranjeiros", UrlImagem = "../../Content/images/hortifrutigranjeiros.jpg"},
                           new Categoria {IdCategoria = 4, Nome = "Laticínios", UrlImagem = "../../Content/images/laticinios.jpg"},
                       };

        }

    }
}