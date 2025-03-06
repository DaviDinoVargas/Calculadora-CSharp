namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double resultado = 0;

            Console.WriteLine("Calculadora Tabajara 2025");

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            resultado = primeiroNumero + segundoNumero;

            Console.WriteLine("Primeiro Número: " + primeiroNumero);
            Console.WriteLine("segundo Número: " + segundoNumero);
            Console.WriteLine("Resultado " + resultado);

            Console.ReadLine();

        }
    }
}
