using System;

class Program
{
    static void Main()
    {
        // Declarar um vetor N com 20 elementos
        int[] N = new int[20];

        // Ler os valores do vetor N
        Console.WriteLine("Digite os 20 elementos do vetor N:");
        for (int i = 0; i < N.Length; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            N[i] = int.Parse(Console.ReadLine());
        }

        // Encontrar o menor elemento e sua posição
        int menorElemento = N[0];
        int posicao = 0;

        for (int i = 1; i < N.Length; i++)
        {
            if (N[i] < menorElemento)
            {
                menorElemento = N[i];
                posicao = i;
            }
        }

        // Mostrar o menor elemento e sua posição
        Console.WriteLine("O menor elemento de N é: {0}", menorElemento);
        Console.WriteLine("Sua posição dentro do vetor é: {0}", posicao);
    }
}
