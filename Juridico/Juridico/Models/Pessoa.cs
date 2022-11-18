using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Pessoa
    {
        public int Numro { get; set; }
        public char TipoPessoa { get; set; } // F = Física , J = Jurídica
        public string Nome { get; set; }
        public string Endereco { get; set; } 

        public List<Pessoa> listaJuridica()
        {
            return null;
        }
        public List<Pessoa> listaFisica()
        {
            return null;
        }
    }
}
