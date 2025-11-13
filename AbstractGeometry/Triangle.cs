using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Triangle : Shape, IHaveHeight
	{
		public abstract double GetHeight();
		public abstract void DrawHeight(PaintEventArgs e);
	
		public Triangle(int startX, int startY, int lineWidth, System.Drawing.Color color) 
			:base(startX, startY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высотоа треугольника: {GetHeight()}");
			base.Info(e);
		}

	}
}
