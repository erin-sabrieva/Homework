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
		private string name;
		private int age;
		private string gender;
		private static string status;

		public Person(string name, int age, string gender)
		{
			Name = name;
			Age = age;
			Gender = gender;
			Status=status;
		
		}

		public string Name
		{
			set { 
				if (Regex.IsMatch(value, @"[a-zA-Z]"))
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
				if (value < 0 ||value > 100)
				{
					throw new Exception("Invalid Age!");
					
				}
				else { this.age = value; }
			}
			get { return this.age; }
			
		}
		public string Gender
		{
			set
			{
				if (value!="female" && value != "male")
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
		public static string Status 
	    {
			set{status= "new";}
			get { return status;}
	        
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
			sb.AppendLine($"Status: {status}");
			return sb.ToString().TrimEnd();
		}
	}
}
