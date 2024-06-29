using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());
        ImprimirDivisoresESalvarSoma(numero);
    }

    static void ImprimirDivisoresESalvarSoma(int numero)
    {
        int somaDivisores = 0;
        Console.WriteLine($"Divisores de {numero}:");
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                somaDivisores += i;
            }
        }
        File.WriteAllText("divisores_soma.txt", somaDivisores.ToString());
        Console.WriteLine($"A soma dos divisores foi salva no arquivo 'divisores_soma.txt'.");
    }
}
