using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace demo_11a
{
	public class Person
	{
		public enum DefineGender
		{
			female,
			male
		}
		private string name;
		private int age;
		private DefineGender gender;
		private static int count;

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
			Gender = gender;
			Count = count;

		}

		public string Name
		{
			set
			{
				if (Regex.IsMatch(value, @"[a-z-A-Z]"))
				{
					this.name = value;
				}
				else
				{
					throw new Exception("Invalid Name");
				}

			}
			get { return this.name; }

		}
		public int Age
		{
			set
			{
				if (value < 0 || value > 116)
				{
					throw new Exception("Invalid Age!");

				}
				else { this.age = value; }
			}
			get { return this.age; }

		}
		public DefineGender Gender
		{

			set
			{
				if (value != DefineGender.female && value != DefineGender.male)
				{
					throw new Exception("Invalid Gender!");
				}
				else
				{
					this.gender = value;
				}
			}
			get { return this.gender; }

		}
		public static int Count
		{
			set { count++; }
			get { return count; }

		}
		public static string Greeting()
		{
			return "Hi I am a person:)";
		}
		public void Eating()
		{
			Console.WriteLine("I am eating breakfast");
		}
		public void Working()
		{
			Console.WriteLine("I'm doing my tasks for the day.");
		}
		public void Sleep()
		{
			Console.WriteLine("I am going to sleep");
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Name: {Name} ");
			sb.AppendLine($"Age: {Age} ");
			sb.AppendLine($"Gender: {Gender}");
			sb.AppendLine($"Count: {count}");
			return sb.ToString().TrimEnd();
		}
	}


}
