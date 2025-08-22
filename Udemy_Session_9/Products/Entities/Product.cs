using System.Globalization;

namespace Udemy_Session_09.Products.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        virtual public string PriceTag()
        {
            return $"{Name} $ " +
                    $"{Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public static Product RegisterProduct()
        {
            Product product = new Product();

            Console.Write("Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return product;
        }

        public static void RegistrationProducts()
        {
            Console.Write("Enter the number of product: ");
            int number = int.Parse(Console.ReadLine());

            Product[] products = new Product[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{Colors.BOLD}Product #{i + 1} data: {Colors.RESET}");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                Product result;

                switch (type)
                {
                    case 'c':
                        result = Product.RegisterProduct();
                        break;
                    case 'u':
                        result = UsedProduct.RegisterUsed();
                        break;
                    case 'i':
                        result = ImportedProduct.RegisterImported();
                        break;
                    default:
                        Console.WriteLine("Invalid type. Please enter 'c', 'u', or 'i'.");
                        i--;
                        continue;
                }
                products[i] = result;
            }

            Console.WriteLine($"\n{Colors.BOLD}PRICE TAGS:{Colors.RESET}");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].PriceTag());
            }
        }
    }
}
