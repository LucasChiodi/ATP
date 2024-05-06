
using System;

class Program
{
    static void Main(string[] args)
    {
        // Contadores
        int divPor3e9 = 0;
        int divPor2e5 = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            // Verificar divisibilidade por 3 e 9
            int somaDigitos = 0;
            int numTemp = numero;
            while (numTemp > 0)
            {
                somaDigitos += numTemp % 10;
                numTemp /= 10;
            }
            if (somaDigitos % 9 == 0)
            {
                divPor3e9++;
            }

            // Verificar divisibilidade por 2 e 5
            if (numero % 2 == 0 && (numero % 10 == 0 || numero % 10 == 5))
            {
                divPor2e5++;
            }
            else
            {
                Console.WriteLine("Número {0} não é divisível pelos valores.", numero);
            }
        }

        // Mostrar resultados
        Console.WriteLine("Quantidade de números divisíveis por 3 e 9: " + divPor3e9);
        Console.WriteLine("Quantidade de números divisíveis por 2 e 5: " + divPor2e5);
    }
}