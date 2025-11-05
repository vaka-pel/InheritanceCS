using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Student:Human
	{
		public string Spesiality { get; set; }
		public string Groupe { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
			(
			string lastName, string firstName, int age,
			string spesiality, string group, double rating, double attendance
			) : base(lastName, firstName, age)
		{
			Init(spesiality, group, rating, attendance);
			Console.WriteLine($"SConstructor:\t{GetHashCode()}");
		}
		public Student
			(
			Human human,
			string spesiality, string group, double rating, double attendance
			) : base(human)
		{
			Init(spesiality, group, rating, attendance);
			Console.WriteLine($"SConstructor:\t{GetHashCode()}");
		}
		public Student(Student other) : base(other)
		{
			Init(other.Spesiality,other.Groupe,other.Rating,other.Attendance);
			Console.WriteLine($"SConstructor:\t{GetHashCode()}");

		}
		~Student()
		{
			Console.WriteLine($"SDestructor:\t{GetHashCode()}");
			
		}
		void Init(string spesiality, string group, double rating, double attendance)
		{
			Spesiality = spesiality;
			Groupe = group;
			Rating = rating;
			Attendance = attendance;

		}

		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{Spesiality} {Groupe} {Rating} {Attendance}");
		}
		public override string ToString()
		{
			return
				base.ToString() +
				$"{Spesiality.PadRight(24)} {Groupe.PadRight(8)}{Rating.ToString().PadRight(8)}{Attendance.ToString().PadRight(8)}";
		}
		public override string ToStringCSV()
		{
			
				return base.ToStringCSV()
				    + $",{Spesiality},{Groupe},{Rating},{Attendance}";
		}
	}
}
