using CalculadoraProj;

namespace TDDCalculadoraTest
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(-5, 10, 5)]
        [InlineData(3, 3, 6)]
        [InlineData(3, 5, 8)]
        [InlineData(7, 7, 14)]
        public void Somar_DoisNumerosInteiro_DeveRetornarCorreto(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(-10, 10, 5)]
        [InlineData(7, 3, 6)]
        [InlineData(4, 5, 8)]
        [InlineData(4, 7, 14)]
        public void Somar_DoisNumerosInteiro_DeveRetornarErro(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.Somar(num1, num2);

            Assert.NotEqual(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(77, 77, 1)]
        [InlineData(81, 9, 9)]
        [InlineData(90, 9, 10)]
        public void DivisaoInteira_DoisNumerosInteiros_DeveRetornarCorreto(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(1050, 5, 1045)]
        [InlineData(19, 6, 13)]
        [InlineData(20, 30, -10)]
        public void Subtrair_DoisNumerosInteiros_DeveRetornarCorreto(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(7, 2, 14)]
        [InlineData(9, 2, 18)]
        [InlineData(3, 3, 9)]
        [InlineData(7, 5, 35)]
        public void Multiplicar_DoisNumerosInteiro_DeveRetornarCorreto(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Fact]

        public void Validar_HistoricoDosCalculos_DeveRetornarCorreto()
        {
            Calculadora _calc = new Calculadora();

            _calc.Somar(9, 2);
            _calc.Somar(10, 5);
            _calc.Dividir(8, 2);
            _calc.Subtrair(10, 5);

            var lista = _calc.Historico();

            Assert.NotEmpty(_calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}