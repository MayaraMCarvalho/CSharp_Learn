using System.Globalization;
using Udemy_Session_15.Entities;

namespace Udemy_Session_15
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');

                    employees.Add(new Employee(
                        fields[0],
                        fields[1],
                        double.Parse(fields[2], CultureInfo.InvariantCulture)));
                }
            }

            Console.Write("Enter salary: ");
            double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emailList = employees
                .Where(x => x.Salary > salaryBase)
                .OrderBy(x => x.Email)
                .Select(x => x.Email);

            Console.WriteLine("\nEmail of people whose salary is more than "
                    + salaryBase.ToString("F2", CultureInfo.InvariantCulture) + ":");

            foreach (string email in emailList)
            {
                Console.WriteLine(email);
            }

            double sumSalary = employees
                .Where(x => x.Name.StartsWith("M"))
                .Sum(x => x.Salary);

            Console.WriteLine("\nSum of salary of people whose name starts with 'M': "
                    + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}