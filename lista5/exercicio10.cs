
Vamos implementar um programa em C# que realiza as seguintes tarefas:

Preenche uma matriz M de 10x10 e a escreve.
Cria procedimentos para realizar as seguintes trocas:
Linha 2 com a linha 8.
Coluna 4 com a coluna 10.
Diagonal principal com a diagonal secundária.
Linha 5 com a coluna 10.
Declara as devidas variáveis e aciona os módulos para exemplificar o uso.
Código C#
csharp
Copiar código
using System;

class Program
{
    static void Main()
    {
        // Declaração da matriz M de 10x10
        int[,] M = new int[10, 10];

        // Chama o procedimento para preencher a matriz e exibí-la
        PreencherMatriz(M);
        Console.WriteLine("Matriz original:");
        ExibirMatriz(M);

        // Realiza e exibe as trocas indicadas
        TrocarLinha2ComLinha8(M);
        Console.WriteLine("Matriz após trocar linha 2 com linha 8:");
        ExibirMatriz(M);

        TrocarColuna4ComColuna10(M);
        Console.WriteLine("Matriz após trocar coluna 4 com coluna 10:");
        ExibirMatriz(M);

        TrocarDiagonalPrincipalComDiagonalSecundaria(M);
        Console.WriteLine("Matriz após trocar diagonal principal com diagonal secundária:");
        ExibirMatriz(M);

        TrocarLinha5ComColuna10(M);
        Console.WriteLine("Matriz após trocar linha 5 com coluna 10:");
        ExibirMatriz(M);
    }

    // Procedimento para preencher a matriz
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 10x10:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Procedimento para exibir a matriz
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{matriz[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    // Procedimento para trocar a linha 2 com a linha 8
    static void TrocarLinha2ComLinha8(int[,] matriz)
    {
        for (int j = 0; j < 10; j++)
        {
            int temp = matriz[1, j]; // Linha 2 é o índice 1 (base 0)
            matriz[1, j] = matriz[7, j]; // Linha 8 é o índice 7 (base 0)
            matriz[7, j] = temp;
        }
    }

    // Procedimento para trocar a coluna 4 com a coluna 10
    static void TrocarColuna4ComColuna10(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, 3]; // Coluna 4 é o índice 3 (base 0)
            matriz[i, 3] = matriz[i, 9]; // Coluna 10 é o índice 9 (base 0)
            matriz[i, 9] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária
    static void TrocarDiagonalPrincipalComDiagonalSecundaria(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, i]; // Diagonal principal
            matriz[i, i] = matriz[i, 9 - i]; // Diagonal secundária
            matriz[i, 9 - i] = temp;
        }
    }

    // Procedimento para trocar a linha 5 com a coluna 10
    static void TrocarLinha5ComColuna10(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[4, i]; // Linha 5 é o índice 4 (base 0)
            matriz[4, i] = matriz[i, 9]; // Coluna 10 é o índice 9 (base 0)
            matriz[i, 9] = temp;
        }
    }
}
