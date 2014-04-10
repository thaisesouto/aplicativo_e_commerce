using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_e_commerce.Models
{
    public class Cliente
    {

        public String NomeCompleto { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public String Endereco { get; set; }

        public String Telefone { get; set; }

        public virtual IEnumerable<Pedido> Pedidos { get; set; }
    }
}