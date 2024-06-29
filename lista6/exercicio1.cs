using System;
 class Exercicio1{
     static void Main(){    
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        int espacos = ContarEspacosEmBranco(frase);
        Console.WriteLine("A frase contém " + ContarEspacosEmBranco(frase) +" espaços em branco.");
    }

    static int ContarEspacosEmBranco(string frase)
    {
        int espacos = 0;
        foreach (char c in frase)
        {
            if (c == ' ')
            {
                espacos++;
            }
        }
        return espacos;
    }
}   