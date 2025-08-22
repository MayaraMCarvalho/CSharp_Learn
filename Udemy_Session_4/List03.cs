using System.Globalization;

namespace List03
{
    public class Cotacao()
    {
        public double   CotacaoDolar;
        public double   QuantidadeDolar;

        double RealToDolar()
        {
            double total = CotacaoDolar * QuantidadeDolar;
            return total += total * 0.06;
        }

        public void ValorTotal()
        {
            Console.WriteLine($"Valor a ser pago em reais = " +
                $"{RealToDolar().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void GetCotacao()
        {
            Cotacao cotacao = new Cotacao();
            Console.Write("Qual é a cotação do dolar? ");
            cotacao.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            cotacao.QuantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cotacao.ValorTotal();
        }
    }

    public class Produto
    {
        public string   Nome;
        public double   Preco;
        public int      Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
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
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

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