using System;

class Program
{
    static void Main(string[] args)
    {
        double salario;
        int numeroFilhos;
        double somaSalarios = 0;
        int somaFilhos = 0;
        int contadorPessoas = 0;
        int contadorSalariosAte100 = 0;
        double maiorSalario = double.MinValue;

        Console.WriteLine("Digite o salário e o número de filhos de cada habitante (digite um salário negativo para encerrar):");

        while (true)
        {
            Console.Write("Salário: R$");
            salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {
                break;
            }

            Console.Write("Número de filhos: ");
            numeroFilhos = int.Parse(Console.ReadLine());

            somaSalarios += salario;
            somaFilhos += numeroFilhos;
            contadorPessoas++;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                contadorSalariosAte100++;
            }
        }

        double mediaSalario = somaSalarios / contadorPessoas;
        double mediaFilhos = (double)somaFilhos / contadorPessoas;
        double percentualSalariosAte100 = (double)contadorSalariosAte100 / contadorPessoas * 100;

        Console.WriteLine("a) A média do salário da população é: R${0:F2}", mediaSalario);
        Console.WriteLine("b) A média do número de filhos é: {0:F2}", mediaFilhos);
        Console.WriteLine("c) O maior salário é: R${0:F2}", maiorSalario);
        Console.WriteLine("d) O percentual de pessoas com salário até R$100,00 é: {0:F2}%", percentualSalariosAte100);
    }
}