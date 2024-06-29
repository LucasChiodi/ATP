using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção: 1 - Inserir dados | 2 - Ler dados | 3 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                InserirDadosAluno();
            }
            else if (opcao == 2)
            {
                LerDadosAlunos();
            }
            else if (opcao == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }

    static void InserirDadosAluno()
    {
        using (StreamWriter writer = new StreamWriter("alunos.txt", true))
        {
            Console.WriteLine("Digite a matrícula do aluno:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Digite o telefone do aluno:");
            string telefone = Console.ReadLine();

            writer.WriteLine($"Matrícula: {matricula}, Telefone: {telefone}");
        }
    }

    static void LerDadosAlunos()
    {
        if (File.Exists("alunos.txt"))
        {
            string[] linhas = File.ReadAllLines("alunos.txt");
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
        else
        {
            Console.WriteLine("Nenhum dado encontrado.");
        }
    }
}
