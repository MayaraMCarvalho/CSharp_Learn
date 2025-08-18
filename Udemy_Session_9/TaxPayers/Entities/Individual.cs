using System.Globalization;

namespace Udemy_Session_9.TaxPayers.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public override double CalculateTax()
        {
            double tax = AnnualIncome > 20000.0 ? AnnualIncome * 0.25 - HealthExpenses * 0.5 : AnnualIncome * 0.15;

            TotalTax += tax;

            return tax > 0 ? tax : 0.0;
        }

        public override void AddData()
        {
            Console.Write("Health expenses: ");
            HealthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name} - $ {CalculateTax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
