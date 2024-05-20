using System;
    class Exercicio2{
        static void Main(){
            Dados();
        }
            static void Dados(){
                double somaSalarios = 0;
                int contadorPessoas = 0;

                while (true){
                    Console.WriteLine("digite o salario do habitante (ou um valor negativo para sair.)");
                    double salario= double.Parse(Console.ReadLine());

                    if (salario<0){
                        break;
                    }
                    Console.WriteLine("digite o numero de filhos do habitantes:");
                    int numeroDeFilhos=int.Parse(Console.ReadLine());

                    somaSalarios+=salario;
                    contadorPessoas++;

                }
                if (contadorPessoas>0){
                    double mediaSalario =somaSalarios/contadorPessoas;
                    Console.WriteLine("a media do salario da população é: " +  mediaSalario);
                }
                else {
                    Console.WriteLine("nehum dado foi coletado.");
                }
            }
    }