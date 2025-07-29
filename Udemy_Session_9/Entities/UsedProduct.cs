using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static void RegisterUsed( int i, Product[] products )
        {
            UsedProduct product = new UsedProduct();

            Console.Write("Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Manufacture date (DD/MM/YYYY): ");
            product.ManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            products[i] = product;
        }
    }
}
