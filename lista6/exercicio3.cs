using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        string fraseCodificada = CodificarCesar(frase, 3);
        Console.WriteLine($"Frase codificada: {fraseCodificada}");
    }

    static string CodificarCesar(string frase, int deslocamento)
    {
        string fraseCodificada = string.Empty;
        foreach (char c in frase)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                fraseCodificada += (char)(((c + deslocamento - offset) % 26) + offset);
            }
            else
            {
                fraseCodificada += c;
            }
        }
        return fraseCodificada;
    }
}