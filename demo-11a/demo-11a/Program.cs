using System;
using System.Collections.Generic;

namespace demo_11a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Въведи брой хора");
				int n = int.Parse(Console.ReadLine());
				List<Person> list = new List<Person>();
				for (int i = 0; i < n; i++)
				{
					Console.WriteLine("Въведи име, години и пол");
					string[] input = Console.ReadLine().Split(" ");
					Person person = new Person(input[0], int.Parse(input[1]), input[2].ToLower());
					list.Add(person);
					Console.WriteLine(Person.Greeting());
					person.Eating();
					person.Working();
					person.Sleep();
					Console.WriteLine(person.ToString());
					Console.WriteLine();
				}
				Console.WriteLine($"Person Count in our program: {list.Count}");
			}
			catch (Exception e)
			{

                Console.WriteLine($"An error occured: {e.Message}");
            }
            


        }
	}
}
