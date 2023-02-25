using Exercicios.Exception;
using Exercicios.Iniciantes.CalculoSimples;

namespace ExerciciosTests.Iniciantes.CalculoSimples
{
    public class PecaTeste
    {
        [Fact]
        public void Calcula_DeveRetornar_Sucesso()
        {
            var entrada = new List<string>
            {
                "12 1 5,30",
                "6 2 5,10"
            };

            var result = new Peca().Calcula(entrada);

            Assert.Equal("VALOR A PAGAR: R$ 15.50", result);
        }

        [Theory]
        [InlineData("12 1 5,30", 12, 1, 5.30)]
        [InlineData("6 2 5,10", 6, 2, 5.10)]
        public void DadosTratados_DeveRetornar_Sucesso(string entrada, int codigo, int quantidade, decimal valorUnitario)
        {
            var result = new Peca().TratarEntrada(entrada);

            Assert.Equal(codigo, result.Codigo);
            Assert.Equal(quantidade, result.Quantidade);
            Assert.Equal(valorUnitario, result.ValorUnitario);
        }

        [Theory]
        [InlineData("6 2 5,1")]
        [InlineData("6 2 5,111")]
        [InlineData("6 2 5,1114")]
        public void EntradasComCasasDecimaisDiferenteDe2_DeveRetornar_Error(string entrada)
        {
            var exception = Assert.Throws<EntradaException>(() => new Peca().TratarEntrada(entrada));

            Assert.Equal("O terceiro valor deve conter 2 casas decimais.", exception.Message);
        }
    }
}
