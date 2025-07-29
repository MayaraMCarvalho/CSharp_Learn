
namespace Udemy_Session_9.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct( string name, double price, double customsFee )
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
            return  $"{Name} $ " +
                    $"{TotalPrice().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} " +
                    $"(Customs fee: $ {CustomsFee.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)})";
        }

        public static ImportedProduct RegisterImported( )
        {
            ImportedProduct product = new ImportedProduct();

            Product result = RegisterProduct();

            product.Name = result.Name;
            product.Price = result.Price;

            Console.Write("Customs fee: ");
            product.CustomsFee = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            return product;
        }
    }
}
