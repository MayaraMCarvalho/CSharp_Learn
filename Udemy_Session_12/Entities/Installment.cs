using System.Globalization;

namespace Udemy_Session_12.Entities
{
    internal class Installment
    {
        public DateOnly DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateOnly dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
