
namespace Udemy_Session_9.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product( string name, double price )
        {
            Name = name;
            Price = price;
        }

        virtual public string PriceTag()
        {
            return  $"{Name} $ " +
                    $"{Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }

        public static void RegisterProduct( int i, Product[] products )
        {
            Product product = new Product();

            Console.Write("Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            products[i] = product;
        }
    }
}
