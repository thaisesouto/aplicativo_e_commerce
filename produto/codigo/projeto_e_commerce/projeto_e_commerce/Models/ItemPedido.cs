using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public partial class ItemPedido
    {
        public int Quantidade { get; set; }

        public virtual Produto Produto { get; set; }

        public Pedido Pedido { get; set; }

    }
}