using System;
using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
		static void Main(string[] args)
		{
			Animal cat = new Animal();
			cat.SetName("Whiskers");
			cat.Sound = "Meow";

			Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

			cat.Owner = "Derek";

			Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

			Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

			Console.WriteLine("# of Animals: {0}", Animal.numOfAnimals);

			Animal cat2 = new Animal();
			cat2.SetName("Petty");

			Console.WriteLine("The cat2 is named {0} and says {1}", cat2.GetName(), cat2.Sound);

			Console.WriteLine("{0} shelter id is {1}", cat2.GetName(), cat2.idNum);

			Console.WriteLine("# of Animals: {0}", Animal.numOfAnimals);

		}

	}
}
