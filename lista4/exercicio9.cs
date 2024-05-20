using System;
    class Exercicio9{
        static void Main(){
            Console.WriteLine("digite o numero de alunos:");
            int numAlunos=int.Parse(Console.ReadLine());

            double mediaAprovados=CalcularMedia(numAlunos);
            if(mediaAprovados>0){
                Console.WriteLine("as medias dos alunos aprovados é: {0}",mediaAprovados);
            }
            else {
                Console.WriteLine("nenhum aluno foi aprovado");
            }
        }
        static double CalcularMedia(int numAlunos){
            int Alunoaprovados=0;
            double somaAprovados=0.0;
            for (int i = 0; i<numAlunos; i++){
                Console.WriteLine("digite a nota do aluno "+(i+1)+":");
                double nota=double.Parse(Console.ReadLine());

            if(nota>=6){
                somaAprovados+=nota;
               Alunoaprovados++;

            }
        }
        if (Alunoaprovados>0){
            return somaAprovados/Alunoaprovados;
        }
        else {
            return 0;
        }
    }    
}