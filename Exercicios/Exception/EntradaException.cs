namespace Exercicios.Exception
{
    public class EntradaException : SystemException
    {
        public EntradaException() : base("O terceiro valor deve conter 2 casas decimais.")
        { }
    }
}
