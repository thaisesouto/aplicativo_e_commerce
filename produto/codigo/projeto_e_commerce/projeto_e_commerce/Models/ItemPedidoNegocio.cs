using projeto_e_commerce.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class ItemPedido
    {
        public void adicionarItemCarrinho(int idProduto)
        {
            var carrinhoAtual = SessionHelper.Carrinho;

            var Produto = new Produto().getProduto(idProduto);

            if (carrinhoAtual.Any(n => n.Produto.IdProduto == idProduto))
            {
                carrinhoAtual.FirstOrDefault(n => n.Produto.IdProduto == idProduto).Quantidade++;
            }
            else
            {
                carrinhoAtual.Add(
                    new ItemPedido
                    {
                        Quantidade = 1,
                        Produto = Produto
                    }
                    );
            }
        }

        public void RemoverItemCarrinho(int idProduto)
        {
            var carrinhoAtual = SessionHelper.Carrinho;

            var Produto = new Produto().getProduto(idProduto);

            var Item = carrinhoAtual.FirstOrDefault(n => n.Produto.IdProduto == idProduto);

            carrinhoAtual.Remove(Item);
        }

        public void AtualizarItemCarrinho(int idProduto, int qntAtual)
        {
            var carrinhoAtual = SessionHelper.Carrinho;

            var Produto = new Produto().getProduto(idProduto);

            var Item = carrinhoAtual.FirstOrDefault(n => n.Produto.IdProduto == idProduto);

            Item.Quantidade = qntAtual;
        }

        public void SetClienteCarrinho(Cliente cli)
        {
            var carrinhoAtual = SessionHelper.Carrinho;
            var pedido = new Pedido()
            {
                Numero = new Random().Next(),
                Cliente = cli,
                ItemPedidos = carrinhoAtual
            };
            SessionHelper.PedidoFinal = pedido;
            
        }

        internal void LimparCarrinho()
        {
            SessionHelper.Carrinho = null;
        }


        public List<ItemPedido> getCarrinho()
        {
            return SessionHelper.Carrinho;
        }
    }
}