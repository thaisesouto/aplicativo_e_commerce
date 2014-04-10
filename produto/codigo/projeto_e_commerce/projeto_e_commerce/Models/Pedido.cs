using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public class Pedido
    {

        public int Numero { get; set; }

        public Double CalcularCustoTotal()
        {
            return 0;
        }

        public virtual IEnumerable<ItemPedido> ItemPedidos { get; set; }

        public Cliente Cliente { get; set; }

    }
}