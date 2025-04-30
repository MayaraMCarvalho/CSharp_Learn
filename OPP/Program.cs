using C__Basics;
using System;

using Vehicles;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string	name = "Mayara";
            string	lastName = "Carvalho";

            Console.WriteLine($"My \"full \bname\" is {name} {lastName}!");
            Console.WriteLine(true);
            int num = 42;
            Console.WriteLine((num == 42) ? "Welcome 42!\n" : "Bye\n");

			int[,]	numbers = { { 1, 4, 2, 8 }, { 3, 6, 8, 7 } };

			Console.WriteLine(Plus(8, 5));
			Console.WriteLine(Plus(4.3, 8.2));
			Console.WriteLine(Plus('R', 8.2));

			List<Vehicle> carList = new List<Vehicle>();

			Vehicle	myCar = new Car();
			Car		myCar2 = new Car("purple", 150);
			
			carList.Add(myCar);
			carList.Add((Vehicle)myCar2);

			//carList[1].Color = "red";

            foreach (Car car in carList)
			{
				Console.Write(Colors.BYELLOW + "✅");
				car.PrintCar();
				Console.WriteLine(Colors.RESET);
			}

			//ProcessarDadosAsync().Wait();
			Console.Write("Car 1: ");
			//myCar.PrintCar();

			//myCar.Color = "red";
			//myCar.Speed = 100; 
			//Console.WriteLine("Car 1: " + myCar.Color + " - " + myCar.Speed + "km/h\n");

			Console.Write("Car 1: ");
			//myCar.PrintCar();
			Console.Write("Car 2: ");
			myCar2.PrintCar();
			//Console.WriteLine(myCar.color);
			Console.WriteLine(Colors.BBLUE);
			myCar.honk();
			Console.WriteLine(Colors.RESET);

			//Animal myAnimal = new Animal();  // Create a Animal object
			Pig myPig = new ();  // Create a Pig object
			Animal myDog = new Dog();  // Create a Dog object

			//myAnimal.animalSound();
			myPig.animalSound();
			myDog.animalSound();
			myDog.sleep();

			try
			{
				if (myCar2.Speed > 100)
				{
					throw new Exception("Speed is too high!!!!");
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.WriteLine("Fim do programa!");

		}

		static int Plus(int x, int y)
		{
			return x + y;
		}

		static double Plus(double x, double y)
		{
			return x + y;
		}

		static async Task ProcessarDadosAsync()
		{
			Console.WriteLine("Iniciando o processamento...");

			int totalEtapas = 100; // Número total de etapas
			for (int i = 1; i <= totalEtapas; i++)
			{
				await Task.Delay(50); // Simula um pequeno atraso entre etapas

				// Usa "\r" para retornar o cursor ao início da linha e sobrescrever
				Console.Write($"\rProgresso: {i}%");
			}

			Console.WriteLine(); // Garante que a próxima saída vá para uma nova linha
			Console.WriteLine("Processamento concluído!");
		}

	}
}
