using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    class Dog : Animal
    {
		public override void animalSound()
		{
			Console.WriteLine("The dog says: bow wow");
		}
	}
}
