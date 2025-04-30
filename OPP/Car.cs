using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Vehicles;

namespace Vehicles
{
    class Car : Vehicle
    {
	
		public string Color { get; set; } = "blue";

		public int Speed { get; set; } = -1;

		public Car()
		{
			this.Color = "blue";
			this.Speed = 0;
			Console.WriteLine(Colors.BGREEN + "Car🚗 created!\n" + Colors.RESET);
		}

		public Car (string color, int speed)
		{
			this.Color = color;
			this.Speed = speed;
			Console.WriteLine(Colors.BGREEN + "Car🚗 created!\n" + Colors.RESET);
		}

		public void PrintCar()
		{
			Console.Write(Color + " - ");
			Console.WriteLine(Speed + "km/h\n");
		}

		public override void honk()
		{
			Console.WriteLine("Biiiii, biiiii!");
		}
	}
}
