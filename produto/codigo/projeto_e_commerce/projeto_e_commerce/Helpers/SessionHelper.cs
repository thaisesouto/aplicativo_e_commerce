using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using projeto_e_commerce.Models;

namespace projeto_e_commerce.Helpers
{
    public class SessionHelper
    {
        private static HttpSessionState Session
        {
            get
            {
                return HttpContext.Current.Session;
            }
        }

        public static CultureInfo Culture
        {
            get
            {
                return (CultureInfo)Session["Culture"];
            }
            set
            {
                Session["Culture"] = value;
            }
        }

        public static List<ItemPedido> Carrinho
        {
            get
            {
                if (Session["Carrinho"] == null)
                {
                    Session["Carrinho"] = new List<ItemPedido>();
                }
                return (List<ItemPedido>)Session["Carrinho"];
            }
            set { Session["Carrinho"] = value; }
        }

        public static Pedido PedidoFinal
        {
            get
            {
                if (Session["PedidoFinal"] == null)
                {
                    Session["PedidoFinal"] = new Pedido();
                }
                return (Pedido)Session["PedidoFinal"];
            }
            set { Session["PedidoFinal"] = value; }
        }
    }
}