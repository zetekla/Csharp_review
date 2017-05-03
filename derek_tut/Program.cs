using System;
using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
		static void Main(string[] args)
		{
			Animal whiskers = new Animal()
			{
				Name = "Whiskers",
				Sound = "Meow"
			};

			Dog grover = new Dog()
			{
				Name = "Grover",
				Sound = "Woof",
				Sound2 = "Grrrr"
			};

			grover.Sound = "Wooooooof";

			whiskers.MakeSound();
			grover.MakeSound();

			whiskers.SetAnimalIDInfo(12345, "Sally Smith");

			grover.SetAnimalIDInfo(12346, "Paul Brown");

			whiskers.GetAnimalIDInfo();

			grover.GetAnimalIDInfo();

			Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

			Console.WriteLine("Is my animal healthy: {0}", getHealth.HealthyWeight(11, 146));

			Animal monkey = new Animal()
			{
				Name = "Happy",
				Sound = "Eeeeeeee"
			};

			Animal spot = new Dog()
			{
				Name = "Spot",
				Sound = "Wooofff",
				Sound2 = "Geeerrrr"
			};

			monkey.MakeSound();
			spot.MakeSound();
			// IS-AS relationship OOP Inheritance
			// Has-A relationship

			// Reptile has Crocodile, Aligator, Stink, Turtle.

			// (electrical) Equipment has-A model
			// A model has-Many Formats


			/* Animal cat = new Animal();
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

			Console.WriteLine("# of Animals: {0}", Animal.numOfAnimals); */

		}

	}
}
