using System.Globalization;

namespace Udemy_Session_09.Products.Entities
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
            return $"{Name} (used) $ " +
                    $"{Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                    $"(Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }

        public static UsedProduct RegisterUsed()
        {
            Product result = RegisterProduct();

            UsedProduct product = new UsedProduct
            {
                Name = result.Name,
                Price = result.Price
            };

            Console.Write("Manufacture date (DD/MM/YYYY): ");
            product.ManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            return product;
        }
    }
}
