using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de letras:");
        int N = int.Parse(Console.ReadLine());
        InserirLetras(N);
        int vogais = ContarVogais("letras.txt");
        Console.WriteLine($"O arquivo contém {vogais} vogais.");
    }

    static void InserirLetras(int N)
    {
        using (StreamWriter writer = new StreamWriter("letras.txt"))
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite a letra {i + 1}:");
                char letra = char.Parse(Console.ReadLine());
                writer.Write(letra);
            }
        }
    }

    static int ContarVogais(string caminhoArquivo)
    {
        string conteudo = File.ReadAllText(caminhoArquivo);
        int vogais = 0;
        foreach (char c in conteudo)
        {
            if ("aeiouAEIOU".Contains(c))
            {
                vogais++;
            }
        }
        return vogais;
    }
}
