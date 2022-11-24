using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Advogado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public Pais Pais { get; set; }

        public List<Advogado> getTodosAdv()
        {
            return null;
        }
        public string getNomeCompleto()
        {
            return this.Nome+" "+this.Sobrenome;
        }
        public Advogado getAdvogadoPorID(int pcodigo)
        {
            return null;
        }
        public List<Advogado> getAdvogadoPorIDPais(int Pais)
        {
            return null;
        }
    }

}
