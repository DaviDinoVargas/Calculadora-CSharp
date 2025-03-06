namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("______________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("______________________________");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            //estrutura de decisão
            
            string opcao = Console.ReadLine().ToUpper();
            if (opcao == "S")
            {
                return;
            }

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            if (opcao == "1") {

                resultado = primeiroNumero + segundoNumero;

            }

            else {

                resultado = primeiroNumero - segundoNumero;
            }

            Console.WriteLine("Primeiro Número: " + primeiroNumero);
            Console.WriteLine("segundo Número: " + segundoNumero);
            Console.WriteLine("Resultado " + resultado);

            Console.ReadLine();

        }
    }
}
