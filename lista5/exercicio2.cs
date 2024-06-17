using System;

class Program
{
    static void Main()
    {
        // Declaração do vetor de notas para 10 alunos
        double[] notas = new double[10];

        // Chama o procedimento para preencher o vetor com as notas
        PreencherNotas(notas);

        // Chama o procedimento para calcular a média e contar notas acima da média
        CalcularMediaEContarAcimaDaMedia(notas);
    }

    // Procedimento para preencher o vetor com as notas dos alunos
    static void PreencherNotas(double[] notas)
    {
        Console.WriteLine("Digite as notas dos 10 alunos:");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Nota do aluno {0}: ", i + 1);
            notas[i] = double.Parse(Console.ReadLine());
        }
    }

    // Procedimento para calcular a média e contar quantos alunos obtiveram nota acima da média
    static void CalcularMediaEContarAcimaDaMedia(double[] notas)
    {
        double soma = 0;
        int quantidadeAcimaDaMedia = 0;

        // Calcula a soma das notas
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        // Calcula a média das notas
        double media = soma / notas.Length;

        // Conta quantos alunos obtiveram nota acima da média
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > media)
            {
                quantidadeAcimaDaMedia++;
            }
        }

        // Exibe a média e o resultado da contagem
        Console.WriteLine("A média da turma é: {0}", media);
        Console.WriteLine("Número de alunos com nota acima da média: {0}", quantidadeAcimaDaMedia);
    }
}