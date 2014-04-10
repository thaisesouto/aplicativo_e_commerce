using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projeto_e_commerce.Models;

namespace projeto_e_commerce.Controllers
{
    public class CarrinhoController : Controller
    {
        //
        // GET: /Carrinho/

        public ActionResult Index()
        {
            var carrinho = new ItemPedido().getCarrinho();
            @ViewBag.SubTotal = carrinho.Sum(n => (n.Quantidade * n.Produto.Preco));
            @ViewBag.Total = carrinho.Sum(n => (n.Quantidade * n.Produto.Preco));


            return View(carrinho);
        }

        [HttpPost]
        public ActionResult Index(string submit, int idProduto = 0, int qntAtual = 0)
        {
            if (submit == "Remover")
            {
                new ItemPedido().RemoverItemCarrinho(idProduto);
            }
            else if (submit == "Atualizar")
            {
                new ItemPedido().AtualizarItemCarrinho(idProduto, qntAtual);
            }
            else if (submit == "Limpar Carrinho")
            {
                new ItemPedido().LimparCarrinho();
            }
            else
            {
                return RedirectToAction("Fechamento");    
            }
            //var carrinho = new ItemPedido().getCarrinho();
            //@ViewBag.SubTotal = carrinho.Sum(n => (n.Quantidade * n.Produto.Preco));
            //@ViewBag.Total = carrinho.Sum(n => (n.Quantidade * n.Produto.Preco));

            return RedirectToAction("Index");
        }

        public ActionResult Fechamento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fechamento(Cliente cliente)
        {
            new ItemPedido().SetClienteCarrinho(cliente);

            //@ViewBag.Total = carrinho.Sum(n => (n.Quantidade * n.Produto.Preco)) + 10;

            return RedirectToAction("Details", "Pedido");
        }

        #region [ Actions ainda não Utilizadas no Carrinho ]

        /*
        //
        // GET: /Carrinho/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Carrinho/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Carrinho/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Carrinho/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Carrinho/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Carrinho/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Carrinho/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
         * */

        #endregion

    }
}
