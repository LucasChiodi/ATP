using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro e positivo N:");
        int N = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("N deve ser um número inteiro e positivo.");
            return;
        }

        double E = 1.0; // Inicializamos E com o primeiro termo da série
        double fatorial = 1.0;

        for (int i = 1; i <= N; i++)
        {
            fatorial *= i;
            E += 1.0 / fatorial;
        }

        Console.WriteLine("O valor de E é: " + E);
    }
}