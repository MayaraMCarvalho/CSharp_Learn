using System;
using System.Globalization;

namespace Udemy_Session_05
{
    public class Produto
    {
        public string   Nome;
        public double   Preco;
        public int      Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int quantity)
        {
           Quantidade += quantity;
        }

        public void RemoverProdutos( int quantity )
        {
            Quantidade -= quantity;
         }

        public override string ToString()
        {
            return $"{Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"{Quantidade} unidades, Total: " +
                   $"{ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public static void Cadastro()
        {            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            produto.AdcionarProdutos(quantity);
            Console.WriteLine($"\nDados atualizados: {produto}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantity);

            Console.WriteLine($"\nDados atualizados: {produto}");
        }
    }
}