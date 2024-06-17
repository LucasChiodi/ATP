using System;

class Program
{
    static void Main()
    {
        // Declaração da matriz M de 5x5
        int[,] M = new int[5, 5];

        // Chama o procedimento para preencher a matriz M
        PreencherMatriz(M);

        // Calcula e exibe as somas
        int somaLinha4 = SomaLinha4(M);
        int somaColuna2 = SomaColuna2(M);
        int somaDiagonalPrincipal = SomaDiagonalPrincipal(M);
        int somaDiagonalSecundaria = SomaDiagonalSecundaria(M);
        int somaTotal = SomaTotal(M);

        Console.WriteLine($"Soma da linha 4 de M: {somaLinha4}");
        Console.WriteLine($"Soma da coluna 2 de M: {somaColuna2}");
        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
        Console.WriteLine($"Soma de todos os elementos da matriz: {somaTotal}");
    }

    // Procedimento para preencher a matriz M
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 5x5:");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para calcular a soma da linha 4 de M
    static int SomaLinha4(int[,] matriz)
    {
        int soma = 0;
        for (int j = 0; j < 5; j++)
        {
            soma += matriz[3, j]; // Linha 4 é o índice 3 (base 0)
        }
        return soma;
    }

    // Função para calcular a soma da coluna 2 de M
    static int SomaColuna2(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 1]; // Coluna 2 é o índice 1 (base 0)
        }
        return soma;
    }

    // Função para calcular a soma da diagonal principal
    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    // Função para calcular a soma da diagonal secundária
    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 4 - i];
        }
        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaTotal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
}