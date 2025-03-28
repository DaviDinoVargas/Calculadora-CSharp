﻿namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
        // atributos de classe
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;
        static decimal resultadoAnterior = 0;

        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            contadorHistorico++;
            return resultado;
        }
        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            contadorHistorico++;
            return resultado;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            contadorHistorico++;
            return resultado;
        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            contadorHistorico++;
            return resultado;
        }
        public static decimal Potenciacao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = (decimal)Math.Pow((double)primeiroNumero, (double)segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} ^ {segundoNumero} = {resultado}";
            contadorHistorico++;
            return resultado;
        }
        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] linhasTabuada = new string[10];

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                linhasTabuada[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}";
            }
            return linhasTabuada;
        }
        public static string[] ObterHistoricoOperacoes()
        {
            return historicoOperacoes;
        }
        public static decimal UsarResultadoAnterior()
        {
            return resultadoAnterior;
        }
    }
}
