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
            //Arrange - Preparação
            Advogado adv = new Advogado();
            adv.Nome = "Vinicius";
            adv.Sobrenome = "Reginaldo";
            string esperado = "Vinicius Reginaldo";
            string resultado;
            //Act - execução
            resultado = adv.getNomeCompleto();

            //Assert - Comparação 
            Assert.Equal(esperado, resultado);
            
        }
        [Theory]
        [InlineData("Reginaldo", "Vinicius", "Reginaldo Vinicius")]
        [InlineData("José", "Santos", "José Santos")]
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
