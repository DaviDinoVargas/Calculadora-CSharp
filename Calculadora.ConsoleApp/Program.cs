namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;
        static decimal resultadoAnterior = 0;
        static void Main(string[] args)
        {

            while (true)
            {
                string opcao = ExibirMenu();

                if (OpcaoSairFoiEscolhida(opcao))
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))
                {
                    ExibirTabuada();
                }

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                {
                    ExibirHistorico();
                }
                
                else

                {
                    ExibirResultado(RealizarCalculo(opcao));
                }
                
                if (!DesejaContinuar())
                    break;
            }
        }

        // função/metodo
        static string ExibirMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calculadora Tabajara");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de Operações");
            Console.WriteLine("7 - Potenciação");
            Console.WriteLine("S - Sair");
            Console.WriteLine("--------------------------------");
            Console.Write("Digite uma opção: ");

            string opcao = Console.ReadLine()!.ToUpper();

            return opcao;
        }

        static bool OpcaoSairFoiEscolhida(string opcao)
        { 
            bool opcaoSairFoiEscolhida = opcao == "S";
            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";
                return opcaoTabuadaFoiEscolhida;
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            bool opcaoHistoricoFoiEscolhida = opcao == "6";
            return opcaoHistoricoFoiEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tabuada");
            Console.WriteLine("--------------------------------");

            Console.Write("Digite o número: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");
            }

            Console.ReadLine();
        }

        static void ExibirHistorico()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Histórico de Operações");
            Console.WriteLine("--------------------------------");

            for (int contador = 0; contador<historicoOperacoes.Length; contador++)
            {
            string valorAtual = historicoOperacoes[contador];

            if (valorAtual != null)
            Console.WriteLine(valorAtual);
             }

             Console.WriteLine("Aperte ENTER para continuar");

        }

        static decimal RealizarCalculo(string operacao)
        {
            decimal primeiroNumero;

            // Só pergunta se deseja continuar se já houver um resultado anterior válido
            if (resultadoAnterior != 0 && ContinuarComResultadoAnterior())
            {
                primeiroNumero = resultadoAnterior;
            }
            else
            {
                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToDecimal(Console.ReadLine());
            }

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;

            if (operacao == "1")
            {
                resultado = Calculadora.Somar(primeiroNumero, segundoNumero);
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (operacao == "2")
            {
                resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            }
            else if (operacao == "3")
            {
                resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            }
            else if (operacao == "4")
            {
                while (segundoNumero == 0)
                {
                    Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");

                    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                }

                resultado = Calculadora.Dividir(primeiroNumero, segundoNumero);
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }
            else if (operacao == "7")
            {
                resultado = Calculadora.Potenciacao(primeiroNumero, segundoNumero);
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} ^ {segundoNumero} = {resultado}";
            }

            contadorHistorico++;
            resultadoAnterior = resultado;
            return resultado;

        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));
            Console.WriteLine("--------------------------------");

        }

        static bool DesejaContinuar()
        {
            Console.Write("Deseja continuar? (S/N): ");
            return Console.ReadLine()!.ToUpper() == "S";
        }

        static bool ContinuarComResultadoAnterior()
        {
            Console.Write("Continuar com o resultado anterior? (S/N): ");
            return Console.ReadLine()!.ToUpper() == "S";
        }

    }
}