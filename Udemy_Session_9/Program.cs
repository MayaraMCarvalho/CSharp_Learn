using System;
using System.Globalization;
using Udemy_Session_9.Entities;

namespace Udemy_Session_9
{
    class Program
    {
        static void Main( string[] args )
        {
            RegistrationProducts();
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

                switch (type)
                {
                    case 'c':
                        Product.RegisterProduct(i, products);
                        break;
                    case 'u':
                        UsedProduct.RegisterUsed(i, products);
                        break;
                    case 'i':
                        ImportedProduct.RegisterImported(i, products);
                        break;
                    default:
                        Console.WriteLine("Invalid type. Please enter 'c', 'u', or 'i'.");
                        i--;
                        continue;
                }
            }

            Console.WriteLine($"\n{Colors.BOLD}PRICE TAGS:{Colors.RESET}");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].PriceTag());
            }
        }
    }
}
