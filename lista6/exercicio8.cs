using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de veículos:");
        int veiculos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do aluguel por veículo:");
        double valorAluguel = double.Parse(Console.ReadLine());

        double faturamentoAnual = CalcularFaturamentoAnual(veiculos, valorAluguel);
        double multaMensal = CalcularMultaMensal(veiculos, valorAluguel);
        double manutencaoAnual = CalcularManutencaoAnual(veiculos);

        Console.WriteLine($"Faturamento Anual: {faturamentoAnual}");
        Console.WriteLine($"Valor ganho com multas mensalmente: {multaMensal}");
        Console.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual}");

        SalvarResultados(faturamentoAnual, multaMensal, manutencaoAnual);
    }

    static double CalcularFaturamentoAnual(int veiculos, double valorAluguel)
    {
        double faturamentoMensal = (veiculos * valorAluguel) / 3;
        return faturamentoMensal * 12;
    }

    static double CalcularMultaMensal(int veiculos, double valorAluguel)
    {
        double faturamentoMensal = (veiculos * valorAluguel) / 3;
        return (faturamentoMensal / 10) * 0.2;
    }

    static double CalcularManutencaoAnual(int veiculos)
    {
        return (veiculos * 0.02) * 600;
    }

    static void SalvarResultados(double faturamentoAnual, double multaMensal, double manutencaoAnual)
    {
        using (StreamWriter writer = new StreamWriter("resultado.txt"))
        {
            writer.WriteLine($"Faturamento Anual: {faturamentoAnual}");
            writer.WriteLine($"Valor ganho com multas mensalmente: {multaMensal}");
            writer.WriteLine($"Valor gasto com manutenção anual: {manutencaoAnual}");
        }
    }
}
