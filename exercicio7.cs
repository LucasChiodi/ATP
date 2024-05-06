using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro e positivo N:");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("N deve ser um número inteiro e positivo.");
            return;
        }

        double S = 0.0;

        Console.WriteLine("Termos gerados:");

        for (int i = 1; i <= N; i++)
        {
            double termo = 1.0 / i;
            S += termo;
            Console.WriteLine("1/{0} = {1}", i, termo);
        }

        Console.WriteLine("Valor final de S: " + S);
    }
}