using System.Globalization;
using Udemy_Session_12.Entities;
using Udemy_Session_12.Services;

namespace Udemy_Session_9
{
    class Program
    {
        static void Main()
        {
            // Ex. 12.1
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly date = DateOnly.ParseExact(Console.ReadLine()!, "dd/MM/yyyy");

            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()!);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}