using PacmanDemo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanDemo
{
    public partial class Game : Form
    {
        int score = 0;
        int msec = 0;
        string direction = "right";
        bool open = true;
        bool hard = false;

        public Game()
        {
            InitializeComponent();
            // rename all walls to "wall", since visual studio doesnt like us changing the names of components without changing the name of the variables 
            foreach (PictureBox wall in GamePanel.Controls.OfType<PictureBox>())
            {

                if ((wall.Name != "cherry") && (wall.Name != "pacman"))
                {
                    wall.Name = "wall";
                }
            }
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            msec++;
            GameUtils.EndGame();
            updateTimer(msec);
        }



        private void updateTimer(int msec)
        {
            int mins = msec / 600;
            int secs = msec / 10 - (mins * 60);
            int msecs = msec - (mins * 600) - (secs * 10);
            GameTimerLabel.Text = mins.ToString() + " : " + secs.ToString() + " : " + msecs.ToString();
        }

        private void updateImage()
        {
            Dictionary<String, Bitmap> images = new Dictionary<String, Bitmap>();
            images.Add("up", Resources.pacman_open_up);
            images.Add("right", Resources.pacman_open_right);
            images.Add("down", Resources.pacman_open_down);
            images.Add("left", Resources.pacman_open_left);
            if (open)
            {
                pacman.Image = Resources.pacman_closed;
                open = false;
            } else
            {
                pacman.Image = images[direction];

                open = true;
            }
        }

        bool speedup = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    DirectionLabel.Text = "Up";
                    direction = "up";
                    PacmanTimer.Enabled = true;
                    break;
                case Keys.Down:
                    DirectionLabel.Text = "Down";
                    direction = "down";
                    PacmanTimer.Enabled = true;
                    break;
                case Keys.Left:
                    DirectionLabel.Text = "Left";
                    direction = "left";
                    PacmanTimer.Enabled = true;
                    break;
                case Keys.Right:
                    DirectionLabel.Text = "Right";
                    direction = "right";
                    PacmanTimer.Enabled = true;
                    break;
                case Keys.Escape:
                    GameTimer.Enabled = !GameTimer.Enabled;
                    CherryTimer.Enabled = !CherryTimer.Enabled;
                    PacmanTimer.Enabled = !PacmanTimer.Enabled;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = !GameTimer.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GameUtils.ResetCherry();
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
            updateImage();

            // direction wrapping
            if (pacman.Location.X < -16)
            {
                pacman.Location = new Point(GamePanel.Width, pacman.Location.Y);
            }
            else if (pacman.Location.X > GamePanel.Width - 16) // move when half of the picturebox is outside the bounds 
            {
                pacman.Location = new Point(0, pacman.Location.Y);
            }
            else if (pacman.Location.Y < -16)
            {
                pacman.Location = new Point(pacman.Location.X, GamePanel.Height);
            }
            else if (pacman.Location.Y > GamePanel.Height - 16)
            {
                pacman.Location = new Point(pacman.Location.X, 0);
            }


            // move pacman
            if (direction == "up")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - 20);

            }
            else if (direction == "down")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + 20);
            }
            else if (direction == "left")
            {
                pacman.Location = new Point(pacman.Location.X - 20, pacman.Location.Y);
            }
            else if (direction == "right")
            {
                pacman.Location = new Point(pacman.Location.X + 20, pacman.Location.Y);

            }
        }

        private void CollisionTimer_Tick(object sender, EventArgs e)
        {
            GameUtils.CheckCollision();
        }
    }
}

