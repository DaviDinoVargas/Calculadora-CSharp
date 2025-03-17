namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;
            return resultado;
        }
        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            return resultado;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;
            return resultado;
        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            return resultado;
        }
        public static decimal Potenciacao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = (decimal)Math.Pow((double)primeiroNumero, (double)segundoNumero);
            return resultado;
        }

    }
}
