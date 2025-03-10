using System.ComponentModel.DataAnnotations;

namespace Calculadora.ConsoleApp
{
    enum Operacao { 
        Somar = 1,
        Subtrair = 2,
        Multiplicar = 3,
        Dividir = 4,
        Tabuada = 5,
        Historico = 6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            bool continuarOperando = false;
            //List<string> historico = new List<string>(); // armazenamento
            int historicoInf = 0;
            string[] historico = new string[100];
            
            Console.WriteLine("______________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("______________________________");

            while (true)
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico");
                Console.WriteLine("S - Sair");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                if (opcao == "6") //histórico
                {
                    Console.WriteLine("______________________________");
                    Console.WriteLine("          Histórico");
                    Console.WriteLine("______________________________");

                    //if (historico.Count == 0)
                    //    Console.WriteLine("Sem Dados");
                    //else
                    //    historico.ForEach(Console.WriteLine);
                    //
                    //Console.WriteLine("______________________________");
                    //Console.ReadLine();
                    //continue;

                    if (historicoInf == 0)
                    {
                        Console.WriteLine("Sem Dados");
                    }
                    else {
                        for (int i = 0; i < historicoInf; i++)
                        {
                            Console.WriteLine(historico[i]);
                        }
                    }
                    Console.ReadLine();
                    continue;

                }
                else if (opcao == "5")
                {
                    Console.WriteLine("______________________________");
                    Console.WriteLine("          Tabuada");
                    Console.WriteLine("______________________________");

                    Console.Write("Digite o número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());



                    for (int contador = 1; contador <= 10; contador++)
                    {

                        int resultadoTabuada = numeroTabuada * contador;

                        //string linhaTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;
                        //string linhaTabuada = $"{numeroTabuada} x {contador} = {resultadoTabuada}";
                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");
                    }
                    Console.ReadLine();
                    continue;

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

                string contaCompleta = "";
                switch (operacao)
                {
                    case Operacao.Somar:
                        resultado = primeiroNumero + segundoNumero;
                        //historico.Add($"{primeiroNumero} + {segundoNumero} = {resultado}");
                        contaCompleta = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                        break;
                    case Operacao.Subtrair:
                        resultado = primeiroNumero - segundoNumero;
                        //historico.Add($"{primeiroNumero} - {segundoNumero} = {resultado}");
                        contaCompleta = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                        break;
                    case Operacao.Multiplicar:
                        resultado = primeiroNumero * segundoNumero;
                        //historico.Add($"{primeiroNumero} * {segundoNumero} = {resultado}");
                        contaCompleta = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                        break;
                    case Operacao.Dividir:
                        while (segundoNumero == 0)
                        {
                            Console.Write("Não é possível dividir por 0.\nDigite novamente: ");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                        }
                        resultado = primeiroNumero / segundoNumero; // Corrigido aqui!
                        //historico.Add($"{primeiroNumero} / {segundoNumero} = {resultado}");
                        contaCompleta = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                        break;
                }
                // if (segundoNumero != 0)
                // {
                // resultado = primeiroNumero / segundoNumero;
                // }

                //else
                //     {
                //    Console.WriteLine("divisão por zero não é permitida");
                //     valido = false;
                //     }
                //     continue;
                //  }
                Console.WriteLine("Resultado: " + resultado);

                if (historicoInf < historico.Length) {
                    historico[historicoInf] = contaCompleta;
                    historicoInf++;
                }
              
                Console.WriteLine("Continuar usando o resultado? (s/n)");
                char continuar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                continuarOperando = char.ToLower(continuar) == 's';
            }
        }
    }
}
