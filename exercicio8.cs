using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de elementos da sequência de Fibonacci que deseja imprimir:");
        int L = int.Parse(Console.ReadLine());

        if (L <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número inteiro positivo.");
            return;
        }

        int anterior = 0;
        int atual = 1;

        Console.WriteLine("Os primeiros {0} elementos da sequência de Fibonacci são:", L);
        Console.Write(anterior + ", " + atual);

        for (int i = 2; i < L; i++)
        {
            int proximo = anterior + atual;
            Console.Write(", " + proximo);
            anterior = atual;
            atual = proximo;
        }

        Console.WriteLine();
    }
}