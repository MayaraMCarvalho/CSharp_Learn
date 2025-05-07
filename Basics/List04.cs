using System;
using System.Globalization;

namespace Lists
{
    public class List04
    {
        public void Ex01()
        {
            int number;

            Console.WriteLine("*** Ex01 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public void Ex02()
        {
            int number, nIn = 0, nOut = 0;

            Console.WriteLine("*** Ex02 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value >= 10 && value <= 20)
                {
                    nIn++;
                }
                else
                {
                    nOut++;
                }
            }
            Console.WriteLine($"{nIn} in");
            Console.WriteLine($"{nOut} out");
        }

        public void Ex03()
        {
            int number;

            Console.WriteLine("*** Ex03 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string [] values = Console.ReadLine().Split(' ');
                double a = double.Parse(values[0], CultureInfo.InvariantCulture);
                double b = double.Parse(values[1], CultureInfo.InvariantCulture);
                double c = double.Parse(values[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;
                Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }

        public void Ex04()
        {
            int number;

            Console.WriteLine("*** Ex04 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int a = int.Parse(values[0]);
                int b = int.Parse(values[1]);
               
                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double) a / b;
                    Console.WriteLine($"{div.ToString("F1", CultureInfo.InvariantCulture)}");
                }    
            }
        }

        public void Ex05()
        {
            int number, factorial = 1;

            Console.WriteLine("*** Ex05 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(1);
                return;
            }
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }

        public void Ex06()
        {
            int number;

            Console.WriteLine("*** Ex06 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Ex07()
        {
            int number;

            Console.WriteLine("*** Ex07 ***");
            Console.WriteLine("Digite o número: ");

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}