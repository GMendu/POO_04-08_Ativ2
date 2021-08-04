using System;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre os dados do produto:\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto Prod1 = new Produto(nome, preco, quantidade);

            Console.WriteLine(Prod1.ToString());
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            Prod1.AdicionarProduto(quant);
            Console.WriteLine(Prod1.ToString());
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine());
            Prod1.RemoverProduto(quant);
            Console.WriteLine(Prod1.ToString());
        }
    }
}
