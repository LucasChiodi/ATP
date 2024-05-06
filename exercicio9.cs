using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número L para calcular a soma dos elementos da série de Fibonacci menores que L:");
        int L = int.Parse(Console.ReadLine());

        if (L <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número inteiro positivo.");
            return;
        }

        int anterior = 0;
        int atual = 1;
        int soma = 0;

        while (atual < L)
        {
            soma += atual;
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        Console.WriteLine("A soma de todos os elementos da série de Fibonacci menores que {0} é: {1}", L, soma);
    }
}