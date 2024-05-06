using System;

class Program
{
    static void Main(string[] args)
    {
        int[] votos = new int[5]; // Índice 0 não será utilizado
        int voto;

        Console.WriteLine("Informe o código do candidato em um voto (0 para encerrar):");

        while (true)
        {
            Console.Write("Código do candidato: ");
            voto = int.Parse(Console.ReadLine());

            if (voto == 0)
            {
                break;
            }

            if (voto >= 1 && voto <= 4)
            {
                votos[voto]++;
            }
            else if (voto == 5)
            {
                votos[0]++; // Votos nulos no índice 0
            }
            else if (voto == 6)
            {
                votos[1]++; // Votos em branco no índice 1
            }
            else
            {
                Console.WriteLine("Código de voto inválido.");
            }
        }

        Console.WriteLine("Total de votos para cada candidato:");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Candidato {0}: {1} votos", i, votos[i]);
        }

        Console.WriteLine("Total de votos nulos: " + votos[0]);
        Console.WriteLine("Total de votos em branco: " + votos[1]);
    }
}