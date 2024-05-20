using System;
    class Exercicio10{
        static void Main(){
            Console.WriteLine("digite a idade do nadador:");
            int idade =int.Parse(Console.ReadLine());

            char categoria= Conceito(idade);
            if(categoria != 'X'){
                Console.WriteLine("a categoria do nadador é:" + categoria);
            }
            else{
                Console.WriteLine("categoria invalida");
            }
        }
        static char Conceito(int idade){
            
            if(idade>=5 && idade<=7){
                return 'F';
            }
            else if(idade>=8 && idade<=10){
                return 'E';
            }
            else if(idade>=11 && idade<=13){
                return 'D';
            }
            else if(idade>=14 && idade<=15){
                return 'C';
            }
            else if(idade>=16 && idade<=17){
                return 'B';
            }
            else if(idade>=18){
                return 'A';
            }
            else{
                return 'X';
            }
        }
    }