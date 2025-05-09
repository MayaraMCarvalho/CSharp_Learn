using System;
using System.Globalization;

namespace Lists
{
	public class List01
	{
		public void Ex01()
		{
			int a, b;

			Console.WriteLine("*** Ex01 ***");
			Console.WriteLine("Digite os valores: ");

			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());

			Console.WriteLine($"SOMA = {a + b}");
		}

		public void Ex02()
		{
			double r, A;

			Console.WriteLine("*** Ex02 ***");
			Console.WriteLine("Digite o valor do raio: ");
			r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			A = Math.PI * r * r;

			Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
		}


		public void Ex03()
		{
			int A, B, C, D;

			Console.WriteLine("*** Ex03 ***");
			Console.WriteLine("Digite os valores: ");
			A = int.Parse(Console.ReadLine());
			B = int.Parse(Console.ReadLine());
			C = int.Parse(Console.ReadLine());
			D = int.Parse(Console.ReadLine());

			Console.WriteLine($"DIFERENCA = {A * B - C * D}");
		}

		public void Ex04()
		{
			int number, hours;
			double valuePerHour;

			Console.WriteLine("*** Ex04 ***");
			Console.WriteLine("Digite os valores: ");
			number = int.Parse(Console.ReadLine());
			hours = int.Parse(Console.ReadLine());
			valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine($"NUMBER = {number}");
			Console.WriteLine($"SALARY = U$ {(hours * valuePerHour).ToString("F2", CultureInfo.InvariantCulture)}");
		}

		public void Ex05()
		{
			double[]	values1, values2;
			double		total;

            Console.WriteLine("*** Ex05 ***");
			Console.WriteLine("Digite os valores: ");
			values1 = Console.ReadLine().Split(' ').Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
			values2 = Console.ReadLine().Split(' ').Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();

            total = values1[1] * values1[2] + values2[1] * values2[2];
            
			Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
		}

		public void Ex06()
		{
			string[]	values;
            double		A, B, C;

            Console.WriteLine("*** Ex06 ***");
            Console.WriteLine("Digite os valores: ");
			values = Console.ReadLine().Split(' ');

            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);
	
            Console.WriteLine($"TRIANGULO: {((A * C / 2.0)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {(Math.PI * C * C).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {(((A + B) * C) / 2.0).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {(B * B).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {(A * B).ToString("F3", CultureInfo.InvariantCulture)}");

        }
	}
}
