using System;
using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
		static void Main(string[] args)
		{
			/* my first program in C# */
			Console.WriteLine("Voting app");
			bool amIableToVote = false;
			amIableToVote = CanIVote();
			Console.WriteLine("Can I vote ? {0}", amIableToVote);
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
