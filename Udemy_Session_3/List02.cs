using System.Globalization;

namespace Lists
{
    public class List02
    {
        public void Ex01()
        {
            int num;

            Console.WriteLine("*** Ex01 ***");
            Console.WriteLine("Digite os valores: ");

            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

        }

        public void Ex02()
        {
            int num;

            Console.WriteLine("*** Ex01 ***");
            Console.WriteLine("Digite os valores: ");

            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        public void Ex03()
        {
            int num1, num2;

            Console.WriteLine("*** Ex03 ***");
            Console.WriteLine("Digite os valores: ");

            string[] str = Console.ReadLine().Split(' ');
            num1 = int.Parse(str[0]);
            num2 = int.Parse(str[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao Sao Multiplos");
            }
        }

        public void Ex04()
        {
            int init, final;

            Console.WriteLine("*** Ex04 ***");
            Console.WriteLine("Digite os valores: ");

            string[] str = Console.ReadLine().Split(' ');
            init = int.Parse(str[0]);
            final = int.Parse(str[1]);

            if (init >= final)
            {
                Console.WriteLine($"O JOGO DUROU {24 - init + final}");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {final - init} HORA(S)");
            }
        }

        public void Ex05()
        {
            int cod, quant;
            float[] price = { 4.00f, 4.50f, 5.00f, 2.00f, 1.50f };

            Console.WriteLine("*** Ex05 ***");
            Console.WriteLine("Digite os valores: ");

            string[] str = Console.ReadLine().Split(' ');
            cod = int.Parse(str[0]);
            quant = int.Parse(str[1]);

            Console.WriteLine($"Total: R$ {(price[cod - 1] * quant).ToString("F2", CultureInfo.InvariantCulture)}");

        }

        public void Ex06()
        {
            float num;

            Console.WriteLine("*** Ex05 ***");
            Console.WriteLine("Digite o valor: ");

            num = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0.0 && num <= 25.0)
                Console.WriteLine("Intervalo [0,25]");
            else if (num > 25.0 && num <= 50.0)
                Console.WriteLine("Intervalo [25,50]");
            else if (num > 50.0 && num <= 75.0)
                Console.WriteLine("Intervalo [50,75]");
            else if (num > 75.0 && num <= 100.0)
                Console.WriteLine("Intervalo [75,100]");
            else
                Console.WriteLine("Fora de intervalo");
        }

        public void Ex07()
        {
            float x, y;

            Console.WriteLine("*** Ex07 ***");
            Console.WriteLine("Digite os valores: ");

            string[] str = Console.ReadLine().Split(' ');
            x = float.Parse(str[0], CultureInfo.InvariantCulture);
            y = float.Parse(str[1], CultureInfo.InvariantCulture);

            string result = (x, y) switch
            {
                (> 0.0f, > 0.0f) => "Q1",
                (< 0.0f, > 0.0f) => "Q2",
                (< 0.0f, < 0.0f) => "Q3",
                (> 0.0f, < 0.0f) => "Q4",
                (0.0f, 0.0f) => "Origem",
                (0.0f, _) => "Eixo Y",
                (_, 0.0f) => "Eixo X",
                _ => "Fora de intervalo"
            };

            Console.WriteLine(result);
        }

        public void Ex08()
        {
            double salary, tax = 0, rest = 0;

            Console.WriteLine("*** Ex08 ***");
            Console.WriteLine("Digite o valor: ");

            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.0)
            {
                Console.WriteLine("Isento");
                return;
            }

            if (salary > 4500.0)
            {
                rest = salary - 4500.0;
                tax += rest * 0.28;
                salary -= rest;
            }

            if (salary > 3000.0)
            {
                rest = salary - 3000.0;
                tax += rest * 0.18;
                salary -= rest;
            }

            tax += (salary - 2000.0) * 0.08;

            Console.WriteLine($"R$ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

}
