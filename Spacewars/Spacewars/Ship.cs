using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Spacewars
{
	abstract class Ship : SpaceObject
	{
		protected Image image;
		Timer blowTimer = new Timer();

		public Ship()
		{
			blowTimer.Interval = 1000;
			blowTimer.Tick += new EventHandler(OnBlow);
		}

		public override void Draw(Graphics graphics)
		{
			graphics.DrawImage(image, Location);
		}

		public abstract Bullet Shoot();

		public override void Blow()
		{
			if (IsHit == false)
			{
				IsHit = true;
				image = Properties.Resources.Blow;
				((Bitmap)image).MakeTransparent(Color.Magenta);
				Size = image.Size;
				blowTimer.Start();
				Form1.timers.Add(blowTimer);
			}
		}

		public void OnBlow(object sender, EventArgs e)
		{
			blowTimer.Stop();
			Form1.timers.Remove(blowTimer);
			IsDead = true;
			DisplayBlowMessageBox(Form1.timers);
		}

		public abstract void DisplayBlowMessageBox(ArrayList timers);
	}
}
