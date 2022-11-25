using Advocacia;
using System;
using Xunit;

namespace Advocacia_TDD
{
    public class AdvocaciaTDD
    {
        [Fact]
        public void MaiorDeIdadeVerdadeiro()
        {
            //Arrange
            Advogado ad = new Advogado();
            ad.Idade = 20;
            bool esperado = true;
            bool resultado = false;
            //act
            resultado = ad.verificarSeAdvogadoEMaiordeIdade();

            // assert
            Assert.Equal(esperado, resultado);



        }
    }
}
