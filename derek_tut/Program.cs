using System;
using System.Linq;

// Used for ArrayLists
using System.Collections;

// Used for Dictionary
using System.Collections.Generic;

using System.Globalization;
using System.Text;

namespace derek_tut
{
	class MainClass
	{
        static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            aList.Add(401);
            aList.Add(402);

            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Count: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse(); // Sally, Mike, Egg

            aList2.Insert(1, "Turkey"); // [Sally, Turkey, Mike, Egg]

            Console.WriteLine(" **range** ");

			// ArrayList range = aList2.GetRange(0, 2); // [Sally, Mike]
            	
            /* aList2.RemoveAt(0); // [Turkey, Mike, Egg]
			aList2.RemoveRange(0, 2); [Egg] */

			foreach (object o in aList2)
			{
				Console.WriteLine(o);
			}

            Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            string[] myArray = (string[])aList2.ToArray(typeof(string));

            string[] customers = { "Bob", "Sally", "Sue" };

            ArrayList custArrayList = new ArrayList();

            custArrayList.AddRange(customers);

            foreach(string s in custArrayList){
                Console.WriteLine(s);
            }

            #endregion

            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            // { "Clark Kent": "Superman", "Bruce Way": :Ba }

            superheroes.Remove("Barry West");

            Console.WriteLine("Count: {0}", superheroes.Count);

            Console.WriteLine("Clark Kent: {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clark Kent", out string kent);

            Console.WriteLine($"Clark Kent - {kent}");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            superheroes.Clear();

            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove 1 : {0}", queue.Dequeue());

            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(", ", numArray));

            foreach(object o in queue){
                Console.WriteLine($"Queue: {o}");
            }

            queue.Clear();

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1 : {0}", stack.Peek());
            Console.WriteLine("Pop 1 : {0}", stack.Pop());
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(", ", numArray2));

			foreach (object o in stack)
			{
				Console.WriteLine($"Stack: {o}");
			}

            stack.Clear();
            // As-A; Has-A
        }

	}
}
