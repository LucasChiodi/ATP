using System;

class Program
{
    static void Main()
    {
        // Chama a função para sortear 3 números entre 10 e 50
        int[] numerosSorteados = SortearNumeros();

        // Exibe os números sorteados (para fins de teste, você pode comentar ou remover esta linha)
        Console.WriteLine("Números sorteados (para teste):");
        foreach (int num in numerosSorteados)
        {
            Console.WriteLine(num);
        }

        // Chama o procedimento para ler as tentativas do usuário
        LerTentativas(numerosSorteados);
    }

    // Função que sorteia 3 números entre 10 e 50
    static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numeros = new int[3];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(10, 51); // Gera números entre 10 e 50 (inclusive)
        }

        return numeros;
    }

    // Procedimento que lê as tentativas do usuário até que ele acerte um dos números sorteados
    static void LerTentativas(int[] numerosSorteados)
    {
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("Digite sua tentativa para acertar um dos números sorteados: ");
            int tentativa = int.Parse(Console.ReadLine());

            foreach (int num in numerosSorteados)
            {
                if (tentativa == num)
                {
                    acertou = true;
                    break;
                }
            }

            if (acertou)
            {
                Console.WriteLine("Parabéns! Você acertou um dos números sorteados.");
            }
            else
            {
                Console.WriteLine("Você não acertou. Tente novamente.");
            }
        }
    }
}