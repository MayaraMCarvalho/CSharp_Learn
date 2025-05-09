using System;
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
            return total += total * 0.06 ;
        }

        public void ValorTotal()
        {
            Console.WriteLine($"Valor a ser pago em reais = " +
                $"{RealToDolar().ToString("F2", CultureInfo.InvariantCulture)}");
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
    }
}