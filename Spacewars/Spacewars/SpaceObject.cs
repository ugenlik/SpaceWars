using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Spacewars
{
	abstract class SpaceObject
	{
		int velocity;
		double angle;
		Point location;
		Point preLocation;
		Size size;
		bool isHit = false;

		public bool IsHit
		{
			get { return isHit; }
			set { isHit = value; }
		}
		bool isDead = false;

		public bool IsDead
		{
			get { return isDead; }
			set { isDead = value; }
		}

		public Rectangle RectangleObject
		{
			get
			{
				return new Rectangle(Location, Size);
			}
		}

		public Size Size
		{
			get { return size; }
			set { size = value; }
		}

		public Point Location
		{
			get { return location; }
			set 
			{
				preLocation = Location; 
				location = value;
			}
		}

		public double Angle // in radians
		{
			get { return angle; }
			set
			{
				angle = value;
				angle %= (Math.PI * 2);
			}
		}

		public int Velocity
		{
			get { return velocity; }
			set 
			{
				if (velocity >= 0)
					velocity = value;
			}
		}

		public abstract void Draw(Graphics graphics);

		public virtual void Move(Rectangle clientRectangle)
		{
			int x = Location.X;
			int y = Location.Y;
			int dx = Convert.ToInt32( Math.Cos(Angle) * velocity );
			int dy = Convert.ToInt32( Math.Sin(Angle) * velocity );

			x += dx;
			y -= dy;

			Point newLocation = new Point(x, y);
			Location = newLocation;
		}

		public void MoveBack()
		{
			location = preLocation;
		}

		public abstract void Blow();
	}
}
