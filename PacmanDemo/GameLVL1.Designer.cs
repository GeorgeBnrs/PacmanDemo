namespace PacmanDemo
{
    partial class Game
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.GameTimerLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.CherryTimer = new System.Windows.Forms.Timer(this.components);
            this.PacmanTimer = new System.Windows.Forms.Timer(this.components);
            this.CollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Silver;
            this.GamePanel.Controls.Add(this.pictureBox8);
            this.GamePanel.Controls.Add(this.pictureBox7);
            this.GamePanel.Controls.Add(this.pictureBox5);
            this.GamePanel.Controls.Add(this.pictureBox4);
            this.GamePanel.Controls.Add(this.pictureBox3);
            this.GamePanel.Controls.Add(this.pictureBox2);
            this.GamePanel.Controls.Add(this.pictureBox1);
            this.GamePanel.Controls.Add(this.pictureBox6);
            this.GamePanel.Controls.Add(this.pacman);
            this.GamePanel.Controls.Add(this.cherry);
            this.GamePanel.Location = new System.Drawing.Point(2, 57);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(994, 646);
            this.GamePanel.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox8.Location = new System.Drawing.Point(527, 293);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox7.Location = new System.Drawing.Point(477, 293);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox5.Location = new System.Drawing.Point(527, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox4.Location = new System.Drawing.Point(53, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox3.Location = new System.Drawing.Point(53, 540);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox2.Location = new System.Drawing.Point(885, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox1.Location = new System.Drawing.Point(885, 540);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PacmanDemo.Properties.Resources.brick_02;
            this.pictureBox6.Location = new System.Drawing.Point(477, 243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pacman
            // 
            this.pacman.Image = global::PacmanDemo.Properties.Resources.pacman_open_border_new;
            this.pacman.Location = new System.Drawing.Point(171, 259);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(50, 50);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman.TabIndex = 1;
            this.pacman.TabStop = false;
            // 
            // cherry
            // 
            this.cherry.Image = global::PacmanDemo.Properties.Resources.cherry1;
            this.cherry.Location = new System.Drawing.Point(758, 261);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(32, 32);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cherry.TabIndex = 0;
            this.cherry.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.ScoreLabel);
            this.panel2.Controls.Add(this.DirectionLabel);
            this.panel2.Controls.Add(this.GameTimerLabel);
            this.panel2.Location = new System.Drawing.Point(2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1959, 57);
            this.panel2.TabIndex = 1;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(146, 23);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(33, 13);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "score";
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.AutoSize = true;
            this.DirectionLabel.Location = new System.Drawing.Point(76, 23);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(47, 13);
            this.DirectionLabel.TabIndex = 1;
            this.DirectionLabel.Text = "direction";
            // 
            // GameTimerLabel
            // 
            this.GameTimerLabel.AutoSize = true;
            this.GameTimerLabel.Location = new System.Drawing.Point(23, 23);
            this.GameTimerLabel.Name = "GameTimerLabel";
            this.GameTimerLabel.Size = new System.Drawing.Size(29, 13);
            this.GameTimerLabel.TabIndex = 0;
            this.GameTimerLabel.Text = "timer";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // CherryTimer
            // 
            this.CherryTimer.Enabled = true;
            this.CherryTimer.Interval = 6000;
            this.CherryTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PacmanTimer
            // 
            this.PacmanTimer.Enabled = true;
            this.PacmanTimer.Tick += new System.EventHandler(this.PacmanTimer_Tick);
            // 
            // CollisionTimer
            // 
            this.CollisionTimer.Enabled = true;
            this.CollisionTimer.Tick += new System.EventHandler(this.CollisionTimer_Tick);
            // 
            // GameLVL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 829);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GamePanel);
            this.Name = "GameLVL1";
            this.Text = "Form1";
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer GameTimer;
        internal System.Windows.Forms.Timer CherryTimer;
        internal System.Windows.Forms.Timer PacmanTimer;
        internal System.Windows.Forms.Timer CollisionTimer;
        internal System.Windows.Forms.Label GameTimerLabel;
        internal System.Windows.Forms.Label DirectionLabel;
        internal System.Windows.Forms.Label ScoreLabel;
        internal System.Windows.Forms.Panel GamePanel;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox pacman;
        internal System.Windows.Forms.PictureBox cherry;
        internal System.Windows.Forms.PictureBox pictureBox6;
        internal System.Windows.Forms.PictureBox pictureBox4;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox8;
        internal System.Windows.Forms.PictureBox pictureBox7;
        internal System.Windows.Forms.PictureBox pictureBox5;
    }
}

