
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números que deseja verificar:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            bool isPositivo = VerificarPositivo(numero);

            if (isPositivo)
            {
                Console.WriteLine("O número {0} é positivo.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é negativo.", numero);
            }
        }
    }

    static bool VerificarPositivo(int numero)
    {
        return numero >= 0;
    }
}