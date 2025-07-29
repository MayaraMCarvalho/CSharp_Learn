
namespace Udemy_Session_9.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return  $"{Name} (used) $ " +
                    $"{Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} " +
                    $"(Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }

        public static UsedProduct RegisterUsed( )
        {
            UsedProduct product = new UsedProduct();

            Product result = RegisterProduct();

            product.Name = result.Name;
            product.Price = result.Price;

            Console.Write("Manufacture date (DD/MM/YYYY): ");
            product.ManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            return product;
        }
    }
}
