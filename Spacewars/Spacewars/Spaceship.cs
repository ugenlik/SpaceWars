using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Spacewars
{
	class Spaceship : Ship
	{
		public Spaceship(Size clientSize)
		{
			image = Properties.Resources.Spaceship;
			((Bitmap)image).MakeTransparent(Color.Magenta);

			Velocity = 10;
			Angle = 0;
			Size = image.Size;

			int x, y;
			x = (clientSize.Width - Size.Width) / 2;
			y = clientSize.Height - Size.Height;
			Location = new Point(x, y);
		}

		public override void Move(Rectangle clientRectangle)
		{
			base.Move(clientRectangle);
			if (!clientRectangle.Contains(new Rectangle(Location, Size)))
			{
				base.MoveBack();
				TurnBack();
				base.Move(clientRectangle);
			}
		}

		public void TurnBack()
		{
			Angle += Math.PI;
		}

		public override Bullet Shoot()
		{
			return new SpaceshipBullet(new Point(
				Location.X + Size.Width / 2 - SpaceshipBullet.bulletSize.Width / 2,
				Location.Y - SpaceshipBullet.bulletSize.Height));
		}

		public Bullet ShootLeft()
		{
			Bullet bullet = Shoot();
			bullet.Angle = 2 * Math.PI / 3;
			return bullet;
		}

		public Bullet ShootRight()
		{
			Bullet bullet = Shoot();
			bullet.Angle = Math.PI / 3;
			return bullet;
		}

		public override void DisplayBlowMessageBox(System.Collections.ArrayList timers)
		{
			Form1.StopTimers();
			MessageBox.Show("Spaceship was destroyed.", "A Hit!", MessageBoxButtons.OK);
			Form1.StartTimers();
		}
	}
}
