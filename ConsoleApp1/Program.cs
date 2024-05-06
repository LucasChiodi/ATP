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

        // Mostrar os resultados
        Console.WriteLine("Quantidade de números positivos: " + positivos);
        Console.WriteLine("Quantidade de números negativos: " + negativos);
        Console.WriteLine("Quantidade de zeros: " + zeros);
    }
}
