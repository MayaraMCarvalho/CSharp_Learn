using System.Globalization;

namespace Udemy_Session_09.TaxPayers.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public override double CalculateTax()
        {
            double tax = AnnualIncome * (NumberEmployees > 10 ? 0.14 : 0.16);

            TotalTax += tax;

            return tax > 0 ? tax : 0.0;
        }

        public override void AddData()
        {
            Console.Write("Number of employees: ");
            NumberEmployees = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{Name} - $ {CalculateTax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
