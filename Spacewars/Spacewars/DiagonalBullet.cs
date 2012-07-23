using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Spacewars
{
	class DiagonalBullet : SpaceshipBullet
	{
		public DiagonalBullet(Point location, double angle)
			: base(location)
		{
			Angle = angle;
		}
	}
}
