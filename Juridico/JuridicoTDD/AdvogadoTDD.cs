using Juridico.Models;
using System;
using Xunit;

namespace JuridicoTDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void advogadoRetornarNomeCompletoTrue()
        {
            //Arrange - Prepara��o
            Advogado adv = new Advogado();
            adv.Nome = "Vinicius";
            adv.Sobrenome = "Reginaldo";
            string esperado = "Vinicius Reginaldo";
            string resultado;
            //Act - execu��o
            resultado = adv.getNomeCompleto();

            //Assert - Compara��o 
            Assert.Equal(esperado, resultado);
            
        }
        [Theory]
        [InlineData("Reginaldo", "Vinicius", "Reginaldo Vinicius")]
        [InlineData("Jos�", "Santos", "Jos� Santos")]
        public void AdvogadoRetornarNomeCompletoVariosCenarios(string nome, string sob, string esperado)
        {
            //Arrange 
            Advogado adv = new Advogado();
            adv.Nome = nome;
            adv.Sobrenome = sob;
            //Act 
            string resultado = adv.getNomeCompleto();

            Assert.Equal(resultado, esperado);
        }
    }
}
