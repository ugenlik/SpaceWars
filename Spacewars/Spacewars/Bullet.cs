using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Spacewars
{
	abstract class Bullet : SpaceObject
	{
		protected Color color;

		public Bullet(Point location)
		{
			Location = location;
		}

		public override void Draw(Graphics graphics)
		{
			graphics.FillRectangle(new SolidBrush(color), new Rectangle(Location, Size));
		}

		public override void Move(Rectangle clientRectangle)
		{
			base.Move(clientRectangle);
		}

		public override void Blow()
		{
			IsDead = true;
		}

		public bool IsOffWindow(Rectangle clientRectangle)
		{
			return !clientRectangle.Contains(RectangleObject);
		}
	}
}
