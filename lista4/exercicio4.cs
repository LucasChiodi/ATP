using System;
    class Exercicio4{
        static void Main(){
            Console.WriteLine("digite os tres lados:");
            double x=double.Parse(Console.ReadLine());
            double y=double.Parse(Console.ReadLine());
            double z=double.Parse(Console.ReadLine());

            Lados(x,y,z);
        }
        static void Lados(double x, double y, double z){
            if(x< y + z && y< x+z && z< x+y){
                if(x==y && y==z){
                    Console.WriteLine("equilatero");

                }
                else if(x==y || y==z || z==x){
                    Console.WriteLine("isosceles");
                }
                else{
                    Console.WriteLine("ESCALENO");
                }
            }
            else{
                Console.WriteLine("nao é um triangulo com estes valores. ");
            }
    
        

        }
    }