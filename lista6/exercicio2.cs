using System;       
    class Exercicio2{
        static void Main(){
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        string fraseSemVogais = RemoverVogais(frase);
        Console.WriteLine($"Frase sem vogais: {fraseSemVogais}");
    }

    static string RemoverVogais(string frase)
    {
        string fraseSemVogais = string.Empty;
        foreach (char c in frase)
        {
            if (!"aeiouAEIOU".Contains(c))
            {
                fraseSemVogais += c;
            }
        }
        return fraseSemVogais;
    }
}