using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class Produto
    {
        public List<Produto> getProdutos()
        {
            return new List<Produto>
                       {
                           new Produto(){ Categoria = new Categoria{IdCategoria = 1},Descricao = "desc1",IdProduto = 1,Nome = "prod1",Preco = 1,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 1},Descricao = "desc2",IdProduto = 2,Nome = "prod2",Preco = 2,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 1},Descricao = "desc3",IdProduto = 3,Nome = "prod3",Preco = 3,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 1},Descricao = "desc4",IdProduto = 4,Nome = "prod4",Preco = 4,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 2},Descricao = "desc5",IdProduto = 5,Nome = "prod5",Preco = 5,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 2},Descricao = "desc6",IdProduto = 6,Nome = "prod6",Preco = 6,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 2},Descricao = "desc8",IdProduto = 8,Nome = "prod8",Preco = 7,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 2},Descricao = "desc9",IdProduto = 9,Nome = "prod9",Preco = 9,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 3},Descricao = "desc10",IdProduto = 10,Nome = "prod10",Preco = 10,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 3},Descricao = "desc11",IdProduto = 11,Nome = "prod11",Preco = 11,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 3},Descricao = "desc12",IdProduto = 12,Nome = "prod12",Preco = 12,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 3},Descricao = "desc13",IdProduto = 13,Nome = "prod13",Preco = 13,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 4},Descricao = "desc14",IdProduto = 14,Nome = "prod14",Preco = 14,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 4},Descricao = "desc15",IdProduto = 15,Nome = "prod15",Preco = 15,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 4},Descricao = "desc16",IdProduto = 16,Nome = "prod16",Preco = 16,UrlImagem = ""},
                           new Produto(){ Categoria = new Categoria{IdCategoria = 4},Descricao = "desc17",IdProduto = 17,Nome = "prod17",Preco = 17,UrlImagem = ""}
                       };
        }

        public Produto getProduto(int Id)
        {
            return getProdutos().FirstOrDefault(n => n.IdProduto == Id);
        }
    }
}