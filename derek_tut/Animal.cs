﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derek_tut
{
	class Animal
	{
		private string name;
		private string sound;

		public const string SHELTER = "Derek's Home for Animals";
		public readonly int idNum;

		public void MakeSound()
		{
			Console.WriteLine("{0} says {1}", name, sound);
		}

		public Animal() : this("No Name", "No Sound")
		{
			
		}

		public Animal(string name) : this(name, "No Sound") { }

		public Animal(string name, string sound)
		{
			SetName(name);
			Sound = sound;
			NumberOfAnimals = 1;

			Random rnd = new Random();
			idNum = rnd.Next(1,2147483640);
		}

		// Setter = Mutator
		public void SetName(string name)
		{
			if (!name.Any(char.IsDigit))
			{
				this.name = name;
			}
			else
			{
				this.name = "No Name";
				Console.WriteLine("Name can't contain numbers");
			}
		}

		// Getter = Accessor
		public string GetName()
		{
			return name;
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
