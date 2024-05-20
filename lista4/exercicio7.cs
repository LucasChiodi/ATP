using System;
      class Exercicio7{
        static void Main(){
            double media;
            int N;
             Console.WriteLine("digite o numero de alunos: ");
             N = int.Parse(Console.ReadLine());

             for(int i=0; i<N; i++){
                Console.WriteLine("digite a media final do aluno" + (i+1)+ ":");
                 media= double.Parse(Console.ReadLine());
                 Procedimento(media);
             }  
        }
        static void Procedimento(double media){
            if(media>=0 && media <= 39){
                Console.WriteLine("conceito F");
            }
            else if(media >= 40  && media <= 59){
                Console.WriteLine("conceito E");
            } 
            else if( media >= 60 && media <=69){
                Console.WriteLine("conceito D");
            }
            else if (media >=70 && media <=79){
                Console.WriteLine("conceito C");
            }
            else if(media>= 80 && media <=89){
                Console.WriteLine("conceito B");
            }
            else if(media>=90 && media<=100){
                Console.WriteLine("conceito A");
            }
            else{
                Console.WriteLine("tipo de media invalida");
            }
         } 
    }