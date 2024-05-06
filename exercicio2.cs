
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ler a sequência
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaços:");
        string input = Console.ReadLine();
        string[] valoresString = input.Split(' ');
        
        // Contadores
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        // Iterar sobre os valores e contar
        for (int i = 0; i < valoresString.Length; i++)
        {
            int valor = int.Parse(valoresString[i]);
            if (valor > 0)
            {
                positivos++;
            }
            else if (valor < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        // Calcular percentuais
        int totalValores = positivos + negativos + zeros;
        double percentualPositivos = (double)positivos / totalValores * 100;
        double percentualNegativos = (double)negativos / totalValores * 100;
        double percentualZeros = (double)zeros / totalValores * 100;

        // Mostrar os resultados
        Console.WriteLine("Quantidade de números positivos: {0} ({1:F2}%)", positivos, percentualPositivos);
        Console.WriteLine("Quantidade de números negativos: {0} ({1:F2}%)", negativos, percentualNegativos);
        Console.WriteLine("Quantidade de zeros: {0} ({1:F2}%)", zeros, percentualZeros);
    }
}