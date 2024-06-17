using System;

class Program
{
    static void Main()
    {
        // Declaração dos vetores X e Y de 10 elementos cada
        int[] X = new int[10];
        int[] Y = new int[10];

        // Chama o procedimento para preencher os vetores X e Y
        PreencherVetor(X, "X");
        PreencherVetor(Y, "Y");

        // Chama o procedimento para gerar o vetor intercalado
        int[] intercalado = GerarVetorIntercalado(X, Y);

        // Chama o procedimento para exibir os vetores
        Console.WriteLine("Vetor X:");
        ExibirVetor(X);

        Console.WriteLine("Vetor Y:");
        ExibirVetor(Y);

        Console.WriteLine("Vetor Intercalado:");
        ExibirVetor(intercalado);
    }

    // Procedimento para preencher o vetor com 10 elementos
    static void PreencherVetor(int[] vetor, string nomeVetor)
    {
        Console.WriteLine($"Digite 10 elementos para o vetor {nomeVetor}:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    // Procedimento para gerar um novo vetor com elementos intercalados de X e Y
    static int[] GerarVetorIntercalado(int[] X, int[] Y)
    {
        int[] intercalado = new int[20];

        for (int i = 0; i < 10; i++)
        {
            intercalado[2 * i] = X[i];      // Posições pares: elementos de X
            intercalado[2 * i + 1] = Y[i];  // Posições ímpares: elementos de Y
        }

        return intercalado;
    }

    // Procedimento para exibir o conteúdo de um vetor
    static void ExibirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Elemento {i}: {vetor[i]}");
        }
    }
}