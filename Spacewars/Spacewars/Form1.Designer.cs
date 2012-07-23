namespace Spacewars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.drawTimer = new System.Windows.Forms.Timer(this.components);
			this.bulletTimer = new System.Windows.Forms.Timer(this.components);
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.backgroundGroupBox = new System.Windows.Forms.GroupBox();
			this.background2Button = new System.Windows.Forms.Button();
			this.background1Button = new System.Windows.Forms.Button();
			this.whiteButton = new System.Windows.Forms.Button();
			this.aliensKilledPanel = new System.Windows.Forms.Panel();
			this.killedAlienCounterLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pauseButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.bulletVelocityGroupBox = new System.Windows.Forms.GroupBox();
			this.spaceshipVelocityLabel = new System.Windows.Forms.Label();
			this.saucerVelocityLabel = new System.Windows.Forms.Label();
			this.spaceshipBulletTrackBar = new System.Windows.Forms.TrackBar();
			this.alienBulletTrackBar = new System.Windows.Forms.TrackBar();
			this.alienBulletColorGroupBox = new System.Windows.Forms.GroupBox();
			this.blackButton = new System.Windows.Forms.Button();
			this.blueButton = new System.Windows.Forms.Button();
			this.redButton = new System.Windows.Forms.Button();
			this.playControlGroupBox = new System.Windows.Forms.GroupBox();
			this.playRadioButton = new System.Windows.Forms.RadioButton();
			this.demoRadioButton = new System.Windows.Forms.RadioButton();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.backgroundGroupBox.SuspendLayout();
			this.aliensKilledPanel.SuspendLayout();
			this.bulletVelocityGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spaceshipBulletTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alienBulletTrackBar)).BeginInit();
			this.alienBulletColorGroupBox.SuspendLayout();
			this.playControlGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// drawTimer
			// 
			this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
			// 
			// bulletTimer
			// 
			this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
			// 
			// mainTimer
			// 
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.backgroundGroupBox);
			this.splitContainer1.Panel1.Controls.Add(this.aliensKilledPanel);
			this.splitContainer1.Panel1.Controls.Add(this.pauseButton);
			this.splitContainer1.Panel1.Controls.Add(this.startButton);
			this.splitContainer1.Panel1.Controls.Add(this.bulletVelocityGroupBox);
			this.splitContainer1.Panel1.Controls.Add(this.alienBulletColorGroupBox);
			this.splitContainer1.Panel1.Controls.Add(this.playControlGroupBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
			this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
			this.splitContainer1.Size = new System.Drawing.Size(701, 646);
			this.splitContainer1.SplitterDistance = 136;
			this.splitContainer1.TabIndex = 0;
			// 
			// backgroundGroupBox
			// 
			this.backgroundGroupBox.Controls.Add(this.background2Button);
			this.backgroundGroupBox.Controls.Add(this.background1Button);
			this.backgroundGroupBox.Controls.Add(this.whiteButton);
			this.backgroundGroupBox.Location = new System.Drawing.Point(390, 13);
			this.backgroundGroupBox.Name = "backgroundGroupBox";
			this.backgroundGroupBox.Size = new System.Drawing.Size(99, 112);
			this.backgroundGroupBox.TabIndex = 6;
			this.backgroundGroupBox.TabStop = false;
			this.backgroundGroupBox.Text = "Background";
			// 
			// background2Button
			// 
			this.background2Button.Location = new System.Drawing.Point(7, 79);
			this.background2Button.Name = "background2Button";
			this.background2Button.Size = new System.Drawing.Size(82, 23);
			this.background2Button.TabIndex = 2;
			this.background2Button.Text = "Background 2";
			this.background2Button.UseVisualStyleBackColor = true;
			this.background2Button.Click += new System.EventHandler(this.background2Button_Click);
			// 
			// background1Button
			// 
			this.background1Button.Location = new System.Drawing.Point(7, 50);
			this.background1Button.Name = "background1Button";
			this.background1Button.Size = new System.Drawing.Size(82, 23);
			this.background1Button.TabIndex = 1;
			this.background1Button.Text = "Background 1";
			this.background1Button.UseVisualStyleBackColor = true;
			this.background1Button.Click += new System.EventHandler(this.background1Button_Click);
			// 
			// whiteButton
			// 
			this.whiteButton.Location = new System.Drawing.Point(7, 20);
			this.whiteButton.Name = "whiteButton";
			this.whiteButton.Size = new System.Drawing.Size(82, 23);
			this.whiteButton.TabIndex = 0;
			this.whiteButton.Text = "White";
			this.whiteButton.UseVisualStyleBackColor = true;
			this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
			// 
			// aliensKilledPanel
			// 
			this.aliensKilledPanel.Controls.Add(this.killedAlienCounterLabel);
			this.aliensKilledPanel.Controls.Add(this.label3);
			this.aliensKilledPanel.Location = new System.Drawing.Point(576, 12);
			this.aliensKilledPanel.Name = "aliensKilledPanel";
			this.aliensKilledPanel.Size = new System.Drawing.Size(111, 113);
			this.aliensKilledPanel.TabIndex = 5;
			// 
			// killedAlienCounterLabel
			// 
			this.killedAlienCounterLabel.AutoSize = true;
			this.killedAlienCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.killedAlienCounterLabel.Location = new System.Drawing.Point(41, 51);
			this.killedAlienCounterLabel.Name = "killedAlienCounterLabel";
			this.killedAlienCounterLabel.Size = new System.Drawing.Size(24, 25);
			this.killedAlienCounterLabel.TabIndex = 1;
			this.killedAlienCounterLabel.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Aliens Killed";
			// 
			// pauseButton
			// 
			this.pauseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.pauseButton.Location = new System.Drawing.Point(495, 80);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(75, 23);
			this.pauseButton.TabIndex = 4;
			this.pauseButton.Text = "Pause";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(495, 51);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// bulletVelocityGroupBox
			// 
			this.bulletVelocityGroupBox.Controls.Add(this.spaceshipVelocityLabel);
			this.bulletVelocityGroupBox.Controls.Add(this.saucerVelocityLabel);
			this.bulletVelocityGroupBox.Controls.Add(this.spaceshipBulletTrackBar);
			this.bulletVelocityGroupBox.Controls.Add(this.alienBulletTrackBar);
			this.bulletVelocityGroupBox.Location = new System.Drawing.Point(217, 13);
			this.bulletVelocityGroupBox.Name = "bulletVelocityGroupBox";
			this.bulletVelocityGroupBox.Size = new System.Drawing.Size(166, 112);
			this.bulletVelocityGroupBox.TabIndex = 2;
			this.bulletVelocityGroupBox.TabStop = false;
			this.bulletVelocityGroupBox.Text = "Bullet Velocity";
			// 
			// spaceshipVelocityLabel
			// 
			this.spaceshipVelocityLabel.AutoSize = true;
			this.spaceshipVelocityLabel.Location = new System.Drawing.Point(118, 79);
			this.spaceshipVelocityLabel.Name = "spaceshipVelocityLabel";
			this.spaceshipVelocityLabel.Size = new System.Drawing.Size(35, 13);
			this.spaceshipVelocityLabel.TabIndex = 3;
			this.spaceshipVelocityLabel.Text = "label2";
			// 
			// saucerVelocityLabel
			// 
			this.saucerVelocityLabel.AutoSize = true;
			this.saucerVelocityLabel.Location = new System.Drawing.Point(118, 29);
			this.saucerVelocityLabel.Name = "saucerVelocityLabel";
			this.saucerVelocityLabel.Size = new System.Drawing.Size(35, 13);
			this.saucerVelocityLabel.TabIndex = 2;
			this.saucerVelocityLabel.Text = "label1";
			// 
			// spaceshipBulletTrackBar
			// 
			this.spaceshipBulletTrackBar.Location = new System.Drawing.Point(7, 68);
			this.spaceshipBulletTrackBar.Maximum = 20;
			this.spaceshipBulletTrackBar.Minimum = 1;
			this.spaceshipBulletTrackBar.Name = "spaceshipBulletTrackBar";
			this.spaceshipBulletTrackBar.Size = new System.Drawing.Size(104, 42);
			this.spaceshipBulletTrackBar.TabIndex = 1;
			this.spaceshipBulletTrackBar.Value = 10;
			this.spaceshipBulletTrackBar.Scroll += new System.EventHandler(this.spaceshipBulletTrackBar_Scroll);
			// 
			// alienBulletTrackBar
			// 
			this.alienBulletTrackBar.Location = new System.Drawing.Point(7, 20);
			this.alienBulletTrackBar.Maximum = 20;
			this.alienBulletTrackBar.Minimum = 1;
			this.alienBulletTrackBar.Name = "alienBulletTrackBar";
			this.alienBulletTrackBar.Size = new System.Drawing.Size(104, 42);
			this.alienBulletTrackBar.TabIndex = 0;
			this.alienBulletTrackBar.Value = 10;
			this.alienBulletTrackBar.Scroll += new System.EventHandler(this.alienBulletTrackBar_Scroll);
			// 
			// alienBulletColorGroupBox
			// 
			this.alienBulletColorGroupBox.Controls.Add(this.blackButton);
			this.alienBulletColorGroupBox.Controls.Add(this.blueButton);
			this.alienBulletColorGroupBox.Controls.Add(this.redButton);
			this.alienBulletColorGroupBox.Location = new System.Drawing.Point(102, 13);
			this.alienBulletColorGroupBox.Name = "alienBulletColorGroupBox";
			this.alienBulletColorGroupBox.Size = new System.Drawing.Size(108, 112);
			this.alienBulletColorGroupBox.TabIndex = 1;
			this.alienBulletColorGroupBox.TabStop = false;
			this.alienBulletColorGroupBox.Text = "Alien Bullet Color";
			// 
			// blackButton
			// 
			this.blackButton.BackColor = System.Drawing.Color.Black;
			this.blackButton.ForeColor = System.Drawing.Color.White;
			this.blackButton.Location = new System.Drawing.Point(7, 79);
			this.blackButton.Name = "blackButton";
			this.blackButton.Size = new System.Drawing.Size(75, 23);
			this.blackButton.TabIndex = 2;
			this.blackButton.Text = "Black";
			this.blackButton.UseVisualStyleBackColor = false;
			this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// blueButton
			// 
			this.blueButton.BackColor = System.Drawing.Color.Blue;
			this.blueButton.ForeColor = System.Drawing.Color.White;
			this.blueButton.Location = new System.Drawing.Point(7, 50);
			this.blueButton.Name = "blueButton";
			this.blueButton.Size = new System.Drawing.Size(75, 23);
			this.blueButton.TabIndex = 1;
			this.blueButton.Text = "Blue";
			this.blueButton.UseVisualStyleBackColor = false;
			this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
			// 
			// redButton
			// 
			this.redButton.BackColor = System.Drawing.Color.Red;
			this.redButton.ForeColor = System.Drawing.Color.White;
			this.redButton.Location = new System.Drawing.Point(7, 20);
			this.redButton.Name = "redButton";
			this.redButton.Size = new System.Drawing.Size(75, 23);
			this.redButton.TabIndex = 0;
			this.redButton.Text = "Red";
			this.redButton.UseVisualStyleBackColor = false;
			this.redButton.Click += new System.EventHandler(this.redButton_Click);
			// 
			// playControlGroupBox
			// 
			this.playControlGroupBox.Controls.Add(this.playRadioButton);
			this.playControlGroupBox.Controls.Add(this.demoRadioButton);
			this.playControlGroupBox.Location = new System.Drawing.Point(13, 13);
			this.playControlGroupBox.Name = "playControlGroupBox";
			this.playControlGroupBox.Size = new System.Drawing.Size(82, 112);
			this.playControlGroupBox.TabIndex = 0;
			this.playControlGroupBox.TabStop = false;
			this.playControlGroupBox.Text = "Play Control";
			// 
			// playRadioButton
			// 
			this.playRadioButton.AutoSize = true;
			this.playRadioButton.Location = new System.Drawing.Point(7, 44);
			this.playRadioButton.Name = "playRadioButton";
			this.playRadioButton.Size = new System.Drawing.Size(45, 17);
			this.playRadioButton.TabIndex = 1;
			this.playRadioButton.Text = "Play";
			this.playRadioButton.UseVisualStyleBackColor = true;
			// 
			// demoRadioButton
			// 
			this.demoRadioButton.AutoSize = true;
			this.demoRadioButton.Checked = true;
			this.demoRadioButton.Location = new System.Drawing.Point(7, 20);
			this.demoRadioButton.Name = "demoRadioButton";
			this.demoRadioButton.Size = new System.Drawing.Size(53, 17);
			this.demoRadioButton.TabIndex = 0;
			this.demoRadioButton.TabStop = true;
			this.demoRadioButton.Text = "Demo";
			this.demoRadioButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AcceptButton = this.startButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.pauseButton;
			this.ClientSize = new System.Drawing.Size(701, 646);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spacewars";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.backgroundGroupBox.ResumeLayout(false);
			this.aliensKilledPanel.ResumeLayout(false);
			this.aliensKilledPanel.PerformLayout();
			this.bulletVelocityGroupBox.ResumeLayout(false);
			this.bulletVelocityGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spaceshipBulletTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alienBulletTrackBar)).EndInit();
			this.alienBulletColorGroupBox.ResumeLayout(false);
			this.playControlGroupBox.ResumeLayout(false);
			this.playControlGroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer drawTimer;
		private System.Windows.Forms.Timer bulletTimer;
		private System.Windows.Forms.Timer mainTimer;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox playControlGroupBox;
		private System.Windows.Forms.RadioButton playRadioButton;
		private System.Windows.Forms.GroupBox alienBulletColorGroupBox;
		private System.Windows.Forms.Button blackButton;
		private System.Windows.Forms.Button blueButton;
		private System.Windows.Forms.Button redButton;
		private System.Windows.Forms.GroupBox bulletVelocityGroupBox;
		private System.Windows.Forms.TrackBar spaceshipBulletTrackBar;
		private System.Windows.Forms.TrackBar alienBulletTrackBar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label spaceshipVelocityLabel;
		private System.Windows.Forms.Label saucerVelocityLabel;
		private System.Windows.Forms.Label killedAlienCounterLabel;
		private System.Windows.Forms.Panel aliensKilledPanel;
		public System.Windows.Forms.RadioButton demoRadioButton;
		private System.Windows.Forms.GroupBox backgroundGroupBox;
		private System.Windows.Forms.Button background2Button;
		private System.Windows.Forms.Button background1Button;
		private System.Windows.Forms.Button whiteButton;
    }
}

