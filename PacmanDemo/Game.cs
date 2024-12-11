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
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void GenerateLevel()
        {

        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            
            msec++;
            if (msec >= 101)
            {
                GameTimer.Stop();
                CherryTimer.Stop();
                PacmanTimer.Stop();
                MessageBox.Show("Game ended, you gathered " + score.ToString() + " cherrys!");
                this.Dispose();
                
            }
            updateTimer(msec);
            updateImage();


            foreach(Control control in GamePanel.Controls)
            {
                if (pacman.Bounds.IntersectsWith(control.Bounds))
                {
                    if (control.Name == "cherry")
                    {
                        score++;
                        ScoreLabel.Text = score.ToString();
                        resetCherry();
                    } else if (control.Name != "pacman") // wall "bounce", excluding ofcourse the pacman itself
                    {
                        if (direction == "up")
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + 20); // move down
                        }
                        else if (direction == "down")
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - 20); // move up
                        }
                        else if (direction == "left")
                        {
                            pacman.Location = new Point(pacman.Location.X + 20, pacman.Location.Y); // move right
                        }
                        else if (direction == "right")
                        {
                            pacman.Location = new Point(pacman.Location.X - 20, pacman.Location.Y); // move left
                        }
                    }
                }
            }


        }

        private void resetCherry()
        {
            Random rnd = new Random();
            int cherryX = rnd.Next(GamePanel.Width - 32); // - 32 so it doesnt appear outside the panel sometimes, since the location is of the top left corner 
            int cherryY = rnd.Next(GamePanel.Height - 32);
            cherry.Location = new Point(cherryX, cherryY);
            CherryTimer.Stop();
            CherryTimer.Start();
        }

        private void updateTimer(int msec)
        {
            int mins = msec / 600;
            int secs = msec / 10 - (mins * 60);
            int msecs = msec - (mins * 600) - (secs * 10);
            GameTimerLAbel.Text = mins.ToString() + " : " + secs.ToString() + " : " + msecs.ToString();
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
                    
                    break;
                case Keys.Down:
                    DirectionLabel.Text = "Down";
                    direction = "down";
                    break;
                case Keys.Left:
                    DirectionLabel.Text = "Left";
                    direction = "left";
                    break;
                case Keys.Right:
                    DirectionLabel.Text = "Right";
                    direction = "right";
                    break;
                case Keys.Space:
                    if (speedup)
                    {
                        GameTimer.Interval = 100;
                        speedup = false;
                    } else
                    {
                        GameTimer.Interval = 50;
                        speedup = true;
                    }
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
            resetCherry();
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
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
    }
}

