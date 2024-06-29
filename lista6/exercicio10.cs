using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminhoArquivo = Console.ReadLine();
        ProcessarArquivoValores(caminhoArquivo);
    }

    static void ProcessarArquivoValores(string caminhoArquivo)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            double[] valores = linhas.Select(linha => double.Parse(linha)).ToArray();

            double valorMaximo = valores.Max();
            double valorMinimo = valores.Min();
            double media = valores.Average();

            Console.WriteLine($"Valor Máximo: {valorMaximo}");
            Console.WriteLine($"Valor Mínimo: {valorMinimo}");
            Console.WriteLine($"Média: {media}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro ao processar o arquivo: " + e.Message);
        }
    }
}
