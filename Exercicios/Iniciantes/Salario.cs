using System.Globalization;

namespace Exercicios.Iniciantes
{
    public class Salario
    {
        public int IdFuncionario { get; set; }
        public int HorasTrabalhadas { get; set; }
        public decimal SalarioHora { get; set; }
        public decimal SalarioFuncionario { get; set; }

        public void EntradaDados()
        {
            IdFuncionario = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            SalarioHora = decimal.Parse(Console.ReadLine());
        }

        public decimal Calcula(int horasTrabalhadas, decimal salarioHora)
        {
            SalarioFuncionario = horasTrabalhadas * salarioHora;

            return SalarioFuncionario;
        }

        public void Print()
        {
           Console.WriteLine($"NUMBER = {IdFuncionario}\nSALARY = U$ {SalarioFuncionario.ToString("n2", new CultureInfo("en-USA"))}");
        }
    }
}
