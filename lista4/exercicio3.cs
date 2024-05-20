using System;
    class Exercicio3{
        static void Main(){
                Console.WriteLine("digiter o numero de conjuntos:");
                int n=int.Parse(Console.ReadLine());
                
                for(int i=0; i<n; i++){
                    Console.WriteLine("digite 3 valores:");
                    int valor1=int.Parse(Console.ReadLine());
                    int valor2=int.Parse(Console.ReadLine());
                    int valor3=int.Parse(Console.ReadLine());

                    Crescente(valor1,valor2,valor3);
                }

        }
        static void Crescente(int a, int b, int c){
        int[] valores = {a,b,c};
        Array.Sort(valores);
         
         Console.WriteLine("valor em ordem crescente:{0},{1},{2}", valores[0], valores[1],valores[2]);
        }
    }
    