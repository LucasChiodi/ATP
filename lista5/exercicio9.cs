using System;

class Program
{
    static void Main()
    {
        // Declaração das matrizes A e B de 4x6
        int[,] A = new int[4, 6];
        int[,] B = new int[4, 6];

        // Chama o procedimento para preencher as matrizes
        PreencherMatriz(A, "A");
        PreencherMatriz(B, "B");

        // Calcula as matrizes S e D
        int[,] S = SomaMatrizes(A, B);
        int[,] D = DiferencaMatrizes(A, B);

        // Exibe as matrizes resultantes
        Console.WriteLine("Matriz A:");
        ExibirMatriz(A);

        Console.WriteLine("Matriz B:");
        ExibirMatriz(B);

        Console.WriteLine("Matriz S (Soma de A e B):");
        ExibirMatriz(S);

        Console.WriteLine("Matriz D (Diferença de A e B):");
        ExibirMatriz(D);
    }

    // Procedimento para preencher uma matriz
    static void PreencherMatriz(int[,] matriz, string nome)
    {
        Console.WriteLine($"Digite os elementos da matriz {nome}:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para calcular a soma de duas matrizes
    static int[,] SomaMatrizes(int[,] A, int[,] B)
    {
        int[,] S = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                S[i, j] = A[i, j] + B[i, j];
            }
        }

        return S;
    }

    // Função para calcular a diferença de duas matrizes (A - B)
    static int[,] DiferencaMatrizes(int[,] A, int[,] B)
    {
        int[,] D = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                D[i, j] = A[i, j] - B[i, j];
            }
        }

        return D;
    }

    // Procedimento para exibir uma matriz
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}