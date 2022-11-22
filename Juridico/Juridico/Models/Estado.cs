using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Estado
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }

        public List<Estado> getTodosEstado()
        {
            return null;
        }
        public Estado getRetomarEstado(int idEstado)
        {
            return null;
        }
    }
}
