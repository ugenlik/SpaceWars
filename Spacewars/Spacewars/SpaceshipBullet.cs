using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Spacewars
{
	class SpaceshipBullet : Bullet
	{
		public static Size bulletSize = new Size(2, 5);

		public SpaceshipBullet(Point location)
			: base(location)
		{
			color = Color.Black;
			Angle = Math.PI / 2;
			Velocity = Properties.Settings.Default.SpaceshipBulletVelocity;
			Size = bulletSize;
		}
	}
}
