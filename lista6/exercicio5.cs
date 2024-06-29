using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminhoArquivo = Console.ReadLine();
        LerEImprimirArquivo(caminhoArquivo);
    }

    static void LerEImprimirArquivo(string caminhoArquivo)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            Console.WriteLine("Conteúdo do arquivo:");
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
            Console.WriteLine($"O arquivo possui {linhas.Length} linhas.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
        }
    }
}
