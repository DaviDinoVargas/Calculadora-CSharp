using System.ComponentModel.DataAnnotations;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            bool continuarOperando = false;

            Console.WriteLine("______________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("______________________________");

            while (true)
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("S - Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                {
                    return;
                }

                double primeiroNumero;
                if (continuarOperando)
                {
                    primeiroNumero = resultado;
                    Console.WriteLine("resultado anterior: " + primeiroNumero);
                }
                else
                {
                    Console.Write("Digite o primeiro número: ");
                    primeiroNumero = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                bool valido = true;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("Inválido: divisão por zero.");
                        valido = false;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                    valido = false;
                }

                if (valido)
                {
                    Console.WriteLine("Resultado: " + resultado);
                }

                Console.WriteLine("Continuar usando o resultado? (s/n)");
                char continuar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                continuarOperando = char.ToLower(continuar) == 's';
            }
        }
    }
}
