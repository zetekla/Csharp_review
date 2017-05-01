using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derek_tut
{
	class Animal
	{
		private string name;
		protected string sound;

		public const string SHELTER = "Derek's Home for Animals";
		public readonly int idNum;

		public void MakeSound()
		{
			Console.WriteLine($"{Name} says {Sound}");
		}

		public Animal() : this("No Name", "No Sound")
		{
			
		}

		public Animal(string name) : this(name, "No Sound") { }

		public Animal(string name, string sound)
		{
			Name = name;
			Sound = sound;
		}

		// Setter = Mutator
		public void Name
		{
			get { return name; }
			set
			{
				if (!value.Any(char.IsDigit))
				{
					name = "No Name";
				}
				name = value;
			}
		}


		public string Sound
		{
			get { return sound; }
			set
			{
				if (value.Length > 10)
				{
					sound = "No Sound";
					Console.WriteLine("Sound is too long");
				}
				sound = value;
			}
		}

		public string Owner{ get; set; } = "No Owner";

		public static int numOfAnimals = 0;

		public static int NumberOfAnimals
		{
			get { return numOfAnimals; }
			set { numOfAnimals += value; }
		}
	} 
}
