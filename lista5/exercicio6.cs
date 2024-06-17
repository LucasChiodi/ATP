
using System;

class Program
{
    static void Main()
    {
        // Declaração do vetor de temperaturas para os 31 dias de outubro
        double[] temperaturas = new double[31];

        // Preenchendo o vetor com temperaturas (valores entre 15°C e 40°C)
        PreencherTemperaturas(temperaturas);

        // Calculando e imprimindo os resultados
        double menorTemperatura = CalcularMenorTemperatura(temperaturas);
        double maiorTemperatura = CalcularMaiorTemperatura(temperaturas);
        double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
        int diasAbaixoDaMedia = ContarDiasAbaixoDaMedia(temperaturas, temperaturaMedia);

        Console.WriteLine($"Menor temperatura ocorrida: {menorTemperatura}°C");
        Console.WriteLine($"Maior temperatura ocorrida: {maiorTemperatura}°C");
        Console.WriteLine($"Temperatura média: {temperaturaMedia}°C");
        Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoDaMedia}");
    }

    // Procedimento para preencher o vetor de temperaturas
    static void PreencherTemperaturas(double[] temperaturas)
    {
        Console.WriteLine("Digite as temperaturas para os 31 dias de outubro:");

        for (int i = 0; i < temperaturas.Length; i++)
        {
            while (true)
            {
                Console.Write($"Temperatura do dia {i + 1}: ");
                double temp = double.Parse(Console.ReadLine());
                if (temp >= 15 && temp <= 40)
                {
                    temperaturas[i] = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("Temperatura inválida. Deve ser entre 15°C e 40°C.");
                }
            }
        }
    }

    // Função para calcular a menor temperatura
    static double CalcularMenorTemperatura(double[] temperaturas)
    {
        double menor = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menor)
            {
                menor = temperaturas[i];
            }
        }
        return menor;
    }

    // Função para calcular a maior temperatura
    static double CalcularMaiorTemperatura(double[] temperaturas)
    {
        double maior = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maior)
            {
                maior = temperaturas[i];
            }
        }
        return maior;
    }

    // Função para calcular a temperatura média
    static double CalcularTemperaturaMedia(double[] temperaturas)
    {
        double soma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }
        return soma / temperaturas.Length;
    }

    // Função para contar o número de dias com temperatura abaixo da média
    static int ContarDiasAbaixoDaMedia(double[] temperaturas, double media)
    {
        int count = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < media)
            {
                count++;
            }
        }
        return count;
    }
}