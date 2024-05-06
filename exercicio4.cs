using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());

        // Verificar se o número é não negativo
        if (numero < 0)
        {
            Console.WriteLine("O fatorial não pode ser calculado para números negativos.");
            return;
        }

        // Calcular o fatorial
        long fatorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }

        // Mostrar o resultado
        Console.WriteLine("{0}! = {1}", numero, fatorial);
    }
}