using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace AbstractGeometry
{
	class IsoscelesTriangle : Triangle
	{
		double @base;//'base' - это ключевое слово, означающее Базовый класс. Ключевые слова нельзя использовать для именования своих сущностей,
					 //но, если перед ключевым словом поставить собаку, то его можно использовать для именования своих сущностей.
		double side;
		public double Base
		{
			get => @base;
			set => @base = FilterSize(value);
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public IsoscelesTriangle
			(
			double @base, double side,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(startX, startY, lineWidth, color)
		{
			Base = @base;
			Side = side;
		}
		public override double GetHeight()
		{
			return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Base / 2, 2));
		}
		public override double GetArea()
		{
			return Base * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return 2 * Side + Base;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] vertices = new Point[]
				{
					new Point(StartX, StartY+(int)@Side),
					new Point(StartX+(int)Base, StartY+(int)@Side),
					new Point(StartX+(int)Base/2, StartY + (int)Side - (int)GetHeight())
				};
			DrawHeight(e);
			e.Graphics.DrawPolygon(pen, vertices);
			
		}
		public override void DrawHeight(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawLine(pen, StartX + (float)@Base / 2, StartY + (float)@Side,
				StartX + (float)@Base / 2, (float)(StartY + @Side - GetHeight()));
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Основание: {Base}");
			Console.WriteLine($"Сторона: {Side}");
			base.Info(e);
		}
	}
}