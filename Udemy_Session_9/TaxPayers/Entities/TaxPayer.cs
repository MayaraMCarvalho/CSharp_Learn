using System.Globalization;

namespace Udemy_Session_9.TaxPayers.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnnualIncome { get; set; }

        public static double TotalTax { get; set; }

        public abstract double CalculateTax();

        public abstract void AddData();

        public static void RegisterTaxPayers()
        {
            TotalTax = 0;

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            TaxPayer[] taxPayers = new TaxPayer[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{Colors.BOLD}Tax payer #{i + 1} data: {Colors.RESET}");
                taxPayers[i] = RegisterTaxPayer();
            }

            Console.WriteLine($"{Colors.BOLD}\nTAXES PAID:{Colors.RESET}");
            foreach (var taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
            }

            Console.WriteLine($"{Colors.BOLD}\nTOTAL TAXES: $ {TotalTax.ToString("F2", CultureInfo.InvariantCulture)}{Colors.RESET}");
        }

        private static TaxPayer RegisterTaxPayer()
        {
            Console.Write("Individual or company (i/c)? ");
            char type = char.Parse(Console.ReadLine().ToLower());

            TaxPayer taxPayer;
            switch (type)
            {
                case 'i':
                    taxPayer = new Individual();
                    break;
                case 'c':
                    taxPayer = new Company();
                    break;
                default:
                    throw new ArgumentException("Invalid tax payer type");
            }

            Console.Write("Name: ");
            taxPayer.Name = Console.ReadLine();

            Console.Write("Annual income: ");
            taxPayer.AnnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            taxPayer.AddData();

            return taxPayer;
        }
    }
}
