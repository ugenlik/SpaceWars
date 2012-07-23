using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Spacewars
{
    public partial class Form1 : Form
	{
		Bitmap buffer;
		Spaceship spaceship;
		ArrayList spaceObjects = new ArrayList();
		public static ArrayList timers = new ArrayList();
		static bool isGamePaused;

		enum Background
		{
			White,
			Background1,
			Background2
		}
		Background background = Background.White;

        public Form1()
        {
            InitializeComponent();
			splitContainer1.SplitterDistance = this.ClientSize.Height / 5;
			saucerVelocityLabel.Text = Properties.Settings.Default.SaucerBulletVelocity.ToString();
			spaceshipVelocityLabel.Text = Properties.Settings.Default.SpaceshipBulletVelocity.ToString();
			
			drawTimer.Interval = 1;
			mainTimer.Interval = 50;
			bulletTimer.Interval = 2000;

			drawTimer.Start();
			timers.Add(mainTimer);
			timers.Add(bulletTimer);

			saucerVelocityLabel.Text = alienBulletTrackBar.Value.ToString();
			spaceshipVelocityLabel.Text = spaceshipBulletTrackBar.Value.ToString();
        }

		public void StartNewGame()
		{
			StopTimers();
			killedAlienCounterLabel.Text = "0";
			spaceship = new Spaceship(splitContainer1.Panel2.ClientSize);
			spaceObjects = new ArrayList();
			spaceObjects.Add(spaceship);
			for (int i = 0; i < Properties.Settings.Default.NumberOfSaucers; i++)
			{
				spaceObjects.Add(new Saucer(splitContainer1.Panel2.ClientRectangle, killedAlienCounterLabel));
			}
			StartTimers();
		}

		static public void StartTimers()
		{
			isGamePaused = false;
			foreach(Timer timer in timers)
			{
				timer.Start();
			}
		}

		static public void StopTimers()
		{
			isGamePaused = true;
			foreach(Timer timer in timers)
			{
				timer.Stop();
			}
		}

		public int CountSoucers()
		{
			int count = 0;
			foreach (SpaceObject spaceObject in spaceObjects)
			{
				if (spaceObject.GetType() == typeof(Saucer))
				{
					count++;
				}
			}
			return count;
		}

        private void drawTimer_Tick(object sender, EventArgs e)
        {
			buffer = new Bitmap(splitContainer1.Panel2.ClientSize.Width, splitContainer1.Panel2.ClientSize.Height);

			Graphics g = Graphics.FromImage(buffer);
			
			g.Clear(Properties.Settings.Default.BackgroundColor);
			switch (background)
			{
				case Background.Background1:
					g.DrawImageUnscaled(Properties.Resources.background1, new Point(0, 0));
					break;
				case Background.Background2:
					g.DrawImageUnscaled(Properties.Resources.background2, new Point(0, 0));
					break;
			}

			foreach (SpaceObject spaceObject in spaceObjects)
			{
				spaceObject.Draw(g);
			}

			g.Dispose();
			splitContainer1.Panel2.CreateGraphics().DrawImageUnscaled(buffer, 0, 0);

			buffer.Dispose();
        }

		private void Form1_Resize(object sender, EventArgs e)
		{
			switch (WindowState)
			{
				case FormWindowState.Minimized:
					drawTimer.Stop();
					pauseButton_Click(null, null);
					break;
				case FormWindowState.Normal:
					drawTimer.Start();
					break;
			}
		}

		private void bulletTimer_Tick(object sender, EventArgs e)
		{
			ArrayList newBullets = new ArrayList();
			if (demoRadioButton.Checked)
			{
				newBullets.Add(spaceship.Shoot());
			}
			foreach (SpaceObject spaceObject in spaceObjects)
			{
				if (spaceObject.GetType() == typeof(Saucer))
				{
					if(!spaceObject.IsHit)
						newBullets.Add(((Saucer)spaceObject).Shoot());
				}
			}
			spaceObjects.AddRange(newBullets);
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			#region move objects
			if(this.demoRadioButton.Checked)
			{
				foreach (SpaceObject spaceObject in spaceObjects)
				{
				spaceObject.Move(splitContainer1.Panel2.ClientRectangle);
				}
			}else if(playRadioButton.Checked)
			{
				for(int i = 1; i < spaceObjects.Count; i++)
				{
					((SpaceObject)spaceObjects[i]).Move(splitContainer1.Panel2.ClientRectangle);
				}
			}
			#endregion

			#region check for hits
			foreach (SpaceObject spaceObject1 in spaceObjects)
			{
				foreach (SpaceObject spaceObject2 in spaceObjects)
				{
					// spaceship hits saucer
					if (spaceObject1.GetType() == typeof(Saucer) &&
						spaceObject2.GetType() == typeof(SpaceshipBullet))
					{
						Rectangle r1 = spaceObject1.RectangleObject;
						Rectangle r2 = spaceObject2.RectangleObject;
						if (r1.Contains(r2))
						{
							spaceObject1.Blow();
							spaceObject2.Blow();
						}
					}
					// saucer hits spaceship
					if (spaceObject1.GetType() == typeof(Spaceship) &&
						spaceObject2.GetType() == typeof(SaucerBullet))
					{
						Rectangle r1 = spaceObject1.RectangleObject;
						Rectangle r2 = spaceObject2.RectangleObject;
						if (r1.Contains(r2))
						{
							spaceObject1.Blow();
							spaceObject2.Blow();
						}
					}
				}
			}
			#endregion

			#region delete dead objects
			ArrayList delObjects = new ArrayList();
			foreach (SpaceObject spaceObject in spaceObjects)
			{
				if (spaceObject.GetType() == typeof(SpaceshipBullet) ||
					spaceObject.GetType() == typeof(SaucerBullet))
				{
					Bullet bullet = (Bullet)spaceObject;
					if (bullet.IsOffWindow(ClientRectangle))
					{
						bullet.IsDead = true;
					}
				}
				if (spaceObject.IsDead)
				{
					delObjects.Add(spaceObject);
				}
			}
			for (int i = 0; i < delObjects.Count; i++)
			{
				spaceObjects.Remove(delObjects[i]);
			}
			#endregion

			#region check for game end
			bool isGameFinished = false;
			bool isAliensWin = false;
			if (spaceObjects[0].GetType() != typeof(Spaceship))
			{
				isGameFinished = isAliensWin = true;
			}
			else if (CountSoucers() == 0)
			{
				isGameFinished = true;
			}
			#endregion
			#region ask for play again
			if (isGameFinished)
			{
				StopTimers();
				DialogResult result;
				if(isAliensWin)
					result = MessageBox.Show("Aliens win!", "Game Over! Play another?", MessageBoxButtons.YesNo);
				else
					result = MessageBox.Show("You win!", "Game Over! Play another?", MessageBoxButtons.YesNo);
				switch (result)
				{
					case DialogResult.Yes:
						StartNewGame();
						break;
					case DialogResult.No:
						this.Close();
						break;
				}
			}
			#endregion
		}

		private void redButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.SaucerBullerColor = Color.Red;
		}

		private void blueButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.SaucerBullerColor = Color.Blue;
		}

		private void blackButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.SaucerBullerColor = Color.Black;
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			Form1.StopTimers();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			Form1.StartTimers();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartNewGame();
			StopTimers();
		}

		private void alienBulletTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = alienBulletTrackBar.Value;
			Properties.Settings.Default.SaucerBulletVelocity = value;
			saucerVelocityLabel.Text = value.ToString();
		}

		private void spaceshipBulletTrackBar_Scroll(object sender, EventArgs e)
		{

			int value = spaceshipBulletTrackBar.Value;
			Properties.Settings.Default.SpaceshipBulletVelocity = value;
			spaceshipVelocityLabel.Text = value.ToString();
		}

		//protected override bool ProcessKeyPreview(ref System.Windows.Forms.Message m)
		//{
		//    switch (m.WParam.ToInt32())
		//    {
		//        case 37: // <--- left arrow.
		//            Console.Write("you pressed the left arrow!\n");
		//            // do stuff for Left Arrow here.
		//            break;
		//        case 38: // <--- up arrow.
		//            Console.Write("you pressed the up arrow!\n");
		//            // do stuff for Up Arrow here.
		//            break;
		//        case 39: // <--- right arrow.
		//            Console.Write("you pressed the right arrow!\n");
		//            // do stuff for Right Arrow here.
		//            break;
		//        case 40: // <--- down arrow.
		//            Console.Write("you pressed the down arrow!\n");
		//            // do stuff for Down Arrow here.
		//            break;
		//    }
		//    return true;
		//}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (playRadioButton.Checked && !isGamePaused)
			{
				switch (keyData)
				{
					case Keys.Left:
						spaceship.Angle = Math.PI;
						spaceship.Move(splitContainer1.Panel2.ClientRectangle);
						return true;
					case Keys.Right:
						spaceship.Angle = 0;
						spaceship.Move(splitContainer1.Panel2.ClientRectangle);
						return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (!isGamePaused && playRadioButton.Checked && spaceship.GetType() == typeof(Spaceship))
			{
				switch (e.Button)
				{
					case MouseButtons.Left:
						spaceObjects.Add(spaceship.Shoot());
						break;
					case MouseButtons.Right:
						spaceObjects.Add(spaceship.ShootLeft());
						spaceObjects.Add(spaceship.ShootRight());
						break;
				}
			}
		}

		private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (playRadioButton.Checked && spaceship.GetType() == typeof(Spaceship) && !isGamePaused)
			{
				Point newLocation = new Point(e.X, spaceship.Location.Y);
				spaceship.Location = newLocation;
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '1':
					splitContainer1_Panel2_MouseDown(null, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
					break;
				case '2':
					splitContainer1_Panel2_MouseDown(null, new MouseEventArgs(MouseButtons.Right, 0, 0, 0, 0));
					break;
			}
		}

		private void whiteButton_Click(object sender, EventArgs e)
		{
			background = Background.White;
		}

		private void background1Button_Click(object sender, EventArgs e)
		{
			background = Background.Background1;
		}

		private void background2Button_Click(object sender, EventArgs e)
		{
			background = Background.Background2;
		}
	}
}
