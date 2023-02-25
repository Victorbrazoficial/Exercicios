using Exercicios.Iniciantes.CalculoSimples;
using Exercicios.Iniciantes;

namespace Exercicios.ExerciciosProgram
{
    public static class TodosOsExercicios
    {
        public static void ExercicioSalario()
        {
            /* Salario
             * Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
             * Entrada:
             *  O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.
             *  Saída:
             *  Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.
             */
            var salario = new Salario();
            salario.EntradaDados();
            salario.Calcula(salario.HorasTrabalhadas, salario.SalarioHora);
            Console.WriteLine(salario.Print());
        }

        public static void ExercicioPeca()
        {
            /*
             * Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
             * Entrada:
             *  O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
             * Saída:
             *  A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
             */
            var peca = new Peca();
            var entrada = peca.Entrada();
            Console.WriteLine(peca.Calcula(entrada));
        }
    }
}
