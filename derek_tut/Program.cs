﻿using System;
using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
		static void Main(string[] args)
		{
			Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
			Warrior bob = new Warrior("Bob", 1000, 120, 40);

			Battle.StartFight(maximus, bob);
		}

	}
}
