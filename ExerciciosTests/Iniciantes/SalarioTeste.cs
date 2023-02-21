using Exercicios.Iniciantes;

namespace ExerciciosTests.Iniciantes
{
    public class SalarioTeste
    {
        [Fact]
        public void Calcula_DeveRetornar_Sucesso()
        {
            var salario = new Salario()
            {
                HorasTrabalhadas = 20,
                SalarioHora = 5.50M
            };
            var esperado = salario.Calcula(salario.HorasTrabalhadas, salario.SalarioHora);

            Assert.Equal(110, esperado);
        }

        [Fact]
        public void Print_DeveRetornar_Sucesso()
        {
            var salario = new Salario()
            {
                HorasTrabalhadas = 20,
                SalarioHora = 5.50M,
                IdFuncionario = 13
            };

            salario.Calcula(salario.HorasTrabalhadas, salario.SalarioHora);
            var esperado = salario.Print();
            var atual = "NUMBER = 13\nSALARY = U$ 110.00";

            Assert.NotNull(esperado);
            Assert.Equal(atual, esperado);
        }
    }
}
