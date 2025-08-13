using System.Globalization;

namespace Udemy_Session_9.Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ " +
                    $"{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                    $"(Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public static ImportedProduct RegisterImported()
        {
            Product result = RegisterProduct();
            ImportedProduct product = new ImportedProduct
            {
                Name = result.Name,
                Price = result.Price
            };

            Console.Write("Customs fee: ");
            product.CustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return product;
        }
    }
}
