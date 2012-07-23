using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Spacewars
{
	class SaucerBullet : Bullet
	{
		public static Size bulletSize = new Size(2, 5);

		public SaucerBullet(Point location)
			: base(location)
		{
			color = Properties.Settings.Default.SaucerBullerColor;
			Angle = Math.PI * 3 / 2;
			Velocity = Properties.Settings.Default.SaucerBulletVelocity;
			Size = bulletSize;
		}
	}
}
