
using System;
    class Exercicio5{
        static void Main(){
            Console.WriteLine(" primeiro numero: ");
            int num1= int.Parse(Console.ReadLine()); 

            Console.WriteLine(" segundo numero: ");
            int num2= int.Parse(Console.ReadLine());

            int mdc= MDC(num1,num2);
            Console.WriteLine("o mdc de {0} e {1} é: {2}", num1,num2,mdc);


        }
        static int MDC(int a, int b){
           if (a == 0){
            return b;
           }
           else if (b==0){
            return a;
           }
        return MDC (b, a % b);
        }
    }