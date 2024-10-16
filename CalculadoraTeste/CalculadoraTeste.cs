using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTeste
{
    public class CalculadoraTests
    {
        public CalculadoraPrincipal construirClasse()
        {
            string data = "data";
            CalculadoraPrincipal calculator = new CalculadoraPrincipal("data");
            return calculator;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 5, 10)]
        public void TesteSomar(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            CalculadoraPrincipal calculator = construirClasse();

            // Act
            int resultadoCalculadora = calculator.Somar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            CalculadoraPrincipal calculator = construirClasse();

            // Act
            int resultadoCalculadora = calculator.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 5, 25)]
        public void TesteMultiplicar(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            CalculadoraPrincipal calculator = construirClasse();

            // Act
            int resultadoCalculadora = calculator.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDividirPorZero()
        {
            // Arrange
            CalculadoraPrincipal calculator = construirClasse();

            // Act // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Dividir(3, 0));
        }

         [Fact]
        public void TestarHistorico()
        {
            // Arrange
            CalculadoraPrincipal calculator = construirClasse();

            // Act 
            calculator.Somar(1, 3);
            calculator.Somar(2, 5);
            calculator.Somar(4, 7);
            var lista = calculator.Historico();

            // Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());
        }
    }
    
}
