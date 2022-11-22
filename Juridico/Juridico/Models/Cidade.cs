using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Cidade
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public Estado estado { get; set; }

        public List<Cidade> getTodasCidades()
        {
            return null;
        }
        public Cidade getRetomarCidade(int idCidade)
        {
            return null;
        }
        public List<Cidade> getCidadesPorEstado(Estado estado)
        {
            return null;
        }
    }
}
