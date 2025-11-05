//#define INHERITANCE_1
//#define INHERITANCE_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Academy
{
	internal class Program
	{
		static readonly string delimiter = "\n---------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Console.WriteLine("Academy");
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pincman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Theacher theacher = new Theacher("White", "Walter", 50, "Chemistry", 25);
			theacher.Info();
			Console.WriteLine(delimiter);
#endif
#if INHERITANCE_2
			Human human = new Human("Pincman", "Jessie", 22);
			human.Info();

			Student student = new Student(human, "Chemistry", "WW_220", 90, 95);
			student.Info();

			Theacher theacher = new Theacher(new Human("White", "Walter", 50, "Chemistry", 25));
			theacher.Info();

			Human h_hank = new Human("Schreder", "Hanc", 40);
			Student s_hank = new Student(h_hank, "Criminalistic", "OBN", 50, 60);
			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
			graduate.Info();
#endif
			Human[] group =
			{
				new Student("Pincman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
				new Theacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Schreder", "Hanc", 40, "Criminalistic", "OBN", 50, 60, "How to catch Heisenberg"),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 90, 95),
				new Theacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
			};

				Console.WriteLine(delimiter);

			for (int i = 0; i < group.Length; i++)
			{
				//group[i].Info();
				Console.WriteLine(group[i].ToString());
				Console.WriteLine(delimiter);
			}
			Save(group, "group.txt");
		}
		static void Save(Human[] group, string filename)
		{ 
			StreamWriter writer = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				writer.WriteLine(group[i].ToStringCSV());
			}
			writer.Close();
			System.Diagnostics.Process.Start("notepad", filename);
		}
	}
}
