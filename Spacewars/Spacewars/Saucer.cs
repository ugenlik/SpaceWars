using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Spacewars
{
	class Saucer : Ship
	{
		Label counter;

		public Saucer(Rectangle clientRectangle, Label counter)
		{
			this.counter = counter;
			image = Properties.Resources.Saucer;
			((Bitmap)image).MakeTransparent(Color.Magenta);
			Size = image.Size;

			// put the saucer to random location in the middle 3/5 of client size
			Rectangle saucerRectangle = CalculateSaucerRectangle(clientRectangle);
			int x, y;
			x = Program.random.Next(saucerRectangle.Width - Size.Width);
			y = Program.random.Next(saucerRectangle.Y, saucerRectangle.Y + saucerRectangle.Height - Size.Height);
			Location =  new Point(x, y);

			Randomize(); // randomize velocity and direction
		}

		public override void Move(Rectangle clientRectangle)
		{
			Rectangle saucerRectangle = CalculateSaucerRectangle(clientRectangle);

			base.Move(saucerRectangle);
			while (!saucerRectangle.Contains(new Rectangle(Location, Size)))
			{
				base.MoveBack();
				Randomize();
				base.Move(saucerRectangle);
			}
		}

		public Rectangle CalculateSaucerRectangle(Rectangle clientRectangle)
		{
			return new Rectangle(clientRectangle.Location.X, clientRectangle.Location.Y, clientRectangle.Width, clientRectangle.Height * 3 / 4);
		}

		public void Randomize()
		{
			Angle = Program.random.NextDouble() * 2 * Math.PI;
			Velocity = Program.random.Next(1, 6);
		}

		public override Bullet Shoot()
		{
			return new SaucerBullet(new Point(Location.X + Size.Width / 2, Location.Y + Size.Height));
		}

		public override void DisplayBlowMessageBox(System.Collections.ArrayList timers)
		{
			Form1.StopTimers();
			MessageBox.Show("A saucer was destroyed.", "A Hit!", MessageBoxButtons.OK);
			Form1.StartTimers();
		}

		public override void Blow()
		{
			if (!IsHit)
			{
				int value = int.Parse(counter.Text);
				value++;
				counter.Text = value.ToString();
			}
			base.Blow();
		}
	}
}
