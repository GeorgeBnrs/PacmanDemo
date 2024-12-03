﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanDemo
{
    public partial class Form1 : Form
    {
        int msec = 0;
        string direction = "right";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            msec++;
            updateTimer(msec);
            if (direction == "up")
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);

            }
            else if (direction == "down")
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
            }
            else if (direction == "left")
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
            }
            else if (direction == "right")
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);

            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Random rnd = new Random();
                int cherryX = rnd.Next(panel1.Width - 35); // -35 so it doesnt appear outside the panel sometimes, since the location is of the top left corner 
                int cherryY = rnd.Next(panel1.Height - 35);
                pictureBox1.Location = new Point(cherryX, cherryY);
            }

        }

        private void updateTimer(int msec)
        {
            int mins = msec / 600;
            int secs = msec / 10 - (mins * 60);
            int msecs = msec - (mins * 600) - (secs * 10);
            label1.Text = mins.ToString() + " : " + secs.ToString() + " : " + msecs.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
                case Keys.Up:
                    label2.Text = "Up";
                    direction = "up";
                    break;
                case Keys.Down:
                    label2.Text = "Down";
                    direction = "down";
                    break;
                case Keys.Left:
                    label2.Text = "Left";
                    direction = "left";
                    break;
                case Keys.Right:
                    label2.Text = "Right";
                    direction = "right";
                    break;
            }
        }
    }
}

