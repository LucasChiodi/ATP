using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaração do vetor X de 10 elementos
        int[] X = new int[10];

        // Chama o procedimento para preencher o vetor X
        PreencherVetor(X);

        // Chama a função para obter os valores negativos de X
        int[] negativos = ObterValoresNegativos(X);

        // Chama o procedimento para exibir o vetor original
        Console.WriteLine("Vetor original:");
        ExibirVetor(X);

        // Chama o procedimento para exibir o vetor com os valores negativos
        Console.WriteLine("Vetor com valores negativos:");
        ExibirVetor(negativos);
    }

    // Procedimento para preencher o vetor com 10 elementos
    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite 10 elementos para o vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    // Função para obter os valores negativos de um vetor
    static int[] ObterValoresNegativos(int[] vetor)
    {
        List<int> negativosList = new List<int>();

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < 0)
            {
                negativosList.Add(vetor[i]);
            }
        }

        return negativosList.ToArray();
    }

    // Procedimento para exibir o conteúdo de um vetor
    static void ExibirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Elemento {0}: {1}", i, vetor[i]);
        }
    }
}