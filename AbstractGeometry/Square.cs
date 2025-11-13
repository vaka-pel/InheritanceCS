using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square : Rectangle
	{
		double side;
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public Square
	(
	double side,
	int startX, int startY, int lineWidth, Color color

	) : base(side, side, startX, startY, lineWidth, color)
		{
			Side = side;
		}
		public override double GetArea() => Side * Side;

		public override double GetPerimeter() => 2 * (Side + Side);
		public override void Draw(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			Brush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Side, (float)Side);
			DrawDiagonal(e);
			//e.Graphics.FillRectangle(brush, StartX, StartY, (float)Side, (float)Side);
		}
		



	}
}
