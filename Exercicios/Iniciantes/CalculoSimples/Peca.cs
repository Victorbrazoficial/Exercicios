using Exercicios.Exception;
using System.Globalization;

namespace Exercicios.Iniciantes.CalculoSimples
{
    /*
     * Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
     * Entrada:
     *  O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
     * Saída:
     *  A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
     */
    public class Peca
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Entrada1 { get; set; }
        public string Entrada2 { get; set; }

        public string Calcula(List<string> entrada)
        {
            var peca01 = TratarEntrada(entrada[0]);
            var peca02 = TratarEntrada(entrada[1]);

            var valorAPagar = (peca01.Quantidade * peca01.ValorUnitario) + (peca02.Quantidade * peca02.ValorUnitario);

            return $"VALOR A PAGAR: R$ {valorAPagar.ToString("N2", new CultureInfo("en-USA"))}";
        }

        public List<string> Entrada()
        {
            Entrada1 = Console.ReadLine();
            Entrada2 = Console.ReadLine();

            var entradas = new List<string>()
            {
                Entrada1,
                Entrada2
            };

            return entradas;
        }

        public Peca TratarEntrada(string entrada)
        {
            var caractereDelimitador = ' ';
            var entradaTratada = entrada.Split(caractereDelimitador);

            var peca = new Peca();

            foreach (var item in entradaTratada)
            {
                if (entradaTratada[0] == item)
                {
                    peca.Codigo = int.Parse(item);
                }

                if (entradaTratada[1] == item)
                {
                    peca.Quantidade = int.Parse(item);
                }

                if (entradaTratada[2] == item)
                {
                    peca.ValorUnitario = decimal.Parse(item);
                    if (!peca.ValorUnitario.ToString().Equals(peca.ValorUnitario.ToString("N2")))
                    {
                        throw new EntradaException();
                    }
                }
            }

            return peca;
        }
    }
}
