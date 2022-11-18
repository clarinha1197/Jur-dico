using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Processo
    {
        public int numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public Pessoa Solicitante { get; set; }
        public Pessoa Acusado { get; set; }
        public Pedidos pedido { get; set; }

        public double getValorTotalPedidos()
        {
            return 0;
        }
        public int getQuantidadePedidos()
        {
            return 0;
        }
        public List<Processo> DistribuicaoDeProcessos()
        {
            return null;
        }
        public List<Processo> getProcessosPorEscritorio()
        {
            return null;
        }
    }
}
