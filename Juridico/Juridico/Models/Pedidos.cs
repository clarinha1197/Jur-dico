using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Pedidos
    {
        public int numero { get; set; }
        public double ValorPedido { get; set; }
        public string DescricaoPedido { get; set; }

        public double getValorPedidosGlobal()
        {
            return 1;
        }
        public double getQuantidadeGlobal()
        {
            return 1;
        }
    }
}
