using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int N = int.Parse(Console.ReadLine());

         
        
            double resultado = CalcularS(N);
            Console.WriteLine("O valor de S é: " + resultado);
        
    }

    static double CalcularS(int N)
    {
        double S = 0;

        for (int i = 1; i <= N; i++)
        {
            S += (double)(i * i + 1) / (i + 3);
        }

        return S;
    }
}