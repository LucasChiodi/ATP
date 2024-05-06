using System;

class Program
{
    static void Main(string[] args)
    {
        double precoCompra;
        double precoVenda;
        int mercadoriasLucroMenor10 = 0;
        int mercadoriasLucroEntre10e20 = 0;
        int mercadoriasLucroMaior20 = 0;
        double totalCompra = 0.0;
        double totalVenda = 0.0;

        Console.WriteLine("Informe o preço de compra e de venda de cada mercadoria (digite 0 para o preço de compra para encerrar):");

        while (true)
        {
            Console.Write("Preço de compra: R$");
            precoCompra = double.Parse(Console.ReadLine());

            if (precoCompra == 0)
            {
                break;
            }

            Console.Write("Preço de venda: R$");
            precoVenda = double.Parse(Console.ReadLine());

            totalCompra += precoCompra;
            totalVenda += precoVenda;

            double lucro = ((precoVenda - precoCompra) / precoCompra) * 100;

            if (lucro < 10)
            {
                mercadoriasLucroMenor10++;
            }
            else if (lucro >= 10 && lucro <= 20)
            {
                mercadoriasLucroEntre10e20++;
            }
            else
            {
                mercadoriasLucroMaior20++;
            }
        }

        double lucroTotal = totalVenda - totalCompra;

        Console.WriteLine("a) Resultado do levantamento do lucro das mercadorias:");
        Console.WriteLine("i) Mercadorias com lucro menor que 10%: " + mercadoriasLucroMenor10);
        Console.WriteLine("ii) Mercadorias com lucro entre 10% e 20%: " + mercadoriasLucroEntre10e20);
        Console.WriteLine("iii) Mercadorias com lucro maior que 20%: " + mercadoriasLucroMaior20);
        Console.WriteLine("b) Valor total de compra: R$" + totalCompra);
        Console.WriteLine("   Valor total de venda: R$" + totalVenda);
        Console.WriteLine("   Lucro total: R$" + lucroTotal);
    }
}