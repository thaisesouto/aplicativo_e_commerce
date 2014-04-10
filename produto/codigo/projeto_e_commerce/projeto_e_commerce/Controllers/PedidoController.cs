using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using projeto_e_commerce.Helpers;
using projeto_e_commerce.Models;

namespace projeto_e_commerce.Controllers
{
    public class PedidoController : Controller
    {
        //
        // GET: /Pedido/Details/5

        public ActionResult Details()
        {
            return View(SessionHelper.PedidoFinal);
        }

        private string ObterTextos(string chave)
        {
            return
                (string)
                ControllerContext.HttpContext.GetGlobalResourceObject("ResourceTextos", chave,
                                                                      Thread.CurrentThread.CurrentUICulture);
        }

    }
}
