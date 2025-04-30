using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
		public string brand { get; set; }

		public virtual void honk()
		{
			Console.WriteLine("Tuut, tuut!");
		}
	}
}
