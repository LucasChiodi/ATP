using System;

class Program
{
    static void Main()
    {
        // Declaração da matriz 4x4
        int[,] matriz = new int[4, 4];

        // Chama o procedimento para preencher a matriz
        PreencherMatriz(matriz);

        // Calcula a soma dos elementos abaixo da diagonal principal
        int somaAbaixoDiagonal = SomaAbaixoDiagonalPrincipal(matriz);

        // Exibe os elementos da diagonal principal
        Console.WriteLine("Elementos da diagonal principal:");
        ExibirDiagonalPrincipal(matriz);

        // Exibe a soma dos elementos abaixo da diagonal principal
        Console.WriteLine($"Soma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");
    }

    // Procedimento para preencher a matriz
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz 4x4:");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para calcular a soma dos elementos abaixo da diagonal principal
    static int SomaAbaixoDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 1; i < 4; i++) // Começa em 1 para evitar a diagonal principal
        {
            for (int j = 0; j < i; j++) // j < i garante que estamos abaixo da diagonal
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

    // Procedimento para exibir os elementos da diagonal principal
    static void ExibirDiagonalPrincipal(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Elemento [{i},{i}]: {matriz[i, i]}");
        }
    }
}