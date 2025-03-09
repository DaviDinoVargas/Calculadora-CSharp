using System.ComponentModel.DataAnnotations;

namespace Calculadora.ConsoleApp
{
    enum Operacao { 
        Somar = 1,
        Subtrair = 2,
        Multiplicar = 3,
        Dividir = 4
    }
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

                if (!Enum.TryParse(opcao, out Operacao operacao) || !Enum.IsDefined(typeof(Operacao), operacao))
                {
                    Console.WriteLine("Opção Inválida");
                    continue;
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

                switch (operacao)
                {
                    case Operacao.Somar:
                    resultado = primeiroNumero + segundoNumero;
                        break;
                    case Operacao.Subtrair:
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case Operacao.Multiplicar:
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case Operacao.Dividir:
                        if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("divisão por zero não é permitida");
                        valido = false;
                    }
                        break;
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
