using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminhoArquivo = Console.ReadLine();
        int contadorA = ContarCaracteresA(caminhoArquivo);
        Console.WriteLine($"O arquivo contém {contadorA} caracteres 'a'.");
    }

    static int ContarCaracteresA(string caminhoArquivo)
    {
        int contadorA = 0;
        try
        {
            string conteudo = File.ReadAllText(caminhoArquivo);
            foreach (char c in conteudo)
            {
                if (c == 'a' || c == 'A')
                {
                    contadorA++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
        }
        return contadorA;
    }
}
