
using System;
    class Exercio1{
        static void Main(){

                Console.WriteLine("digiet o numero de alunos:");
                int n=int.Parse(Console.ReadLine());
                
                for(int i=0; i<n; i++){
                    Console.WriteLine("digite as tres notas do aluno " + (i+1)+":");
                    double nota1=double.Parse(Console.ReadLine());
                    double nota2=double.Parse(Console.ReadLine());
                    double nota3=double.Parse(Console.ReadLine());

                    Console.WriteLine("digite 'A' para media aritmetica e 'p' para media ponderada: ");
                    char Letra=char.Parse(Console.ReadLine().ToUpper());
                    Procedimento(nota1,nota2,nota3,Letra);
                }

        }
        static void Procedimento(double nota1, double nota2, double nota3, char Letra){
            
            if(Letra== 'A'){
            double mediaAritmetica = (nota1+nota2+nota3)/3;
             Console.WriteLine("a media aritmetica é :" + mediaAritmetica);
            }
            else if (Letra== 'P'){
                double mediaPonderada= (nota1*5 + nota2*3 + nota3*2)/10;
                Console.WriteLine("a media poonderada é :" + mediaPonderada);
            }
            else {
                Console.WriteLine("tipo de media inavlido.");
            }
            

            
        } 
      }
    
