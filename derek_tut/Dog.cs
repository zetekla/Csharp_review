﻿using System;
namespace derek_tut
{
	class Dog : Animal 
	{
		public string Sound2 { get; set; } = "Grrrr";

		public override void MakeSound()
		{
			Console.WriteLine($"{Name} says {Sound} and {Sound2}");
		}

		public Dog(string name = "No Name", 
           string sound = "No Sound", 
           string sound2 = "No Sound")
			:base(name, sound)
		{
			Sound2 = sound2;
		}
	}
}
