using System;
using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
		static void Main(string[] args)
		{
			Animal fox = new Animal()
			{
				name = "Red",
				sound = "Raaww"
			};

			fox.MakeSound();
			Console.WriteLine("# of Animals: {0} ", Animal.GetNumAnimals());

			Console.WriteLine("Area of Rectangle: {0}", ShapeMath.GetArea("rectangle", 5, 6));

			int? randNum = null;
			if (randNum == null)
			{
				Console.WriteLine("randNum is null");
			}

			if (!randNum.HasValue)
			{
				Console.WriteLine("randNum doesn't have Value");
			}
		}

		static bool CanIVote()
		{
			Console.WriteLine("How old are you?");
			int age = 0;
			age = Int32.Parse(Console.ReadLine());
			return (age >= 18);
		}

	}
}
