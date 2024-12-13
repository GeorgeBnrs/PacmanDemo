using Newtonsoft.Json;
using PacmanDemo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        SettingsValues svalues;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // rename all walls to "wall", since this isnt supported by the designer
            foreach (PictureBox wall in GamePanel.Controls.OfType<PictureBox>())
            {
                if ((wall.Name != "cherry") && (wall.Name != "pacman"))
                {
                    wall.Name = "wall";
                }
            }
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            // load settings
            try
            {
                svalues = JsonConvert.DeserializeObject<SettingsValues>(File.ReadAllText("settings.json"));
            }
            catch (FileNotFoundException)
            {
                svalues = new SettingsValues();
            }
            if (svalues.DeadlyWalls) { label1.Visible = true; }
            CherryTimer.Interval = svalues.CherryRespawnTime * 1000;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            msec++;
            //
            // TODO: VARIABLE TIME
            //
            if (msec >= 1201)
            {
                EndGame();
            }
            updateTimer(msec);
            updateImage();
        }

        private void EndGame()
        {
            GameTimer.Stop();
            CherryTimer.Stop();
            PacmanTimer.Stop();
            MessageBox.Show("Game ended, you gathered " + score.ToString() + " cherrys!");
            Dispose();
        }

        private void ResetCherry()
        {
            Random rnd = new Random();
            int cherryX = rnd.Next(GamePanel.Width - 32); // - 32 so it doesnt appear outside the panel sometimes, since the location is of the top left corner 
            int cherryY = rnd.Next(GamePanel.Height - 32);
            cherry.Visible = false;
            cherry.Location = new Point(cherryX, cherryY);
            foreach (Control control in GamePanel.Controls)
            {
                while (cherry.Bounds.IntersectsWith(control.Bounds) && (control.Name != "cherry"))
                {
                    cherryX = rnd.Next(GamePanel.Width - 32);
                    cherryY = rnd.Next(GamePanel.Height - 32);
                    cherry.Location = new Point(cherryX, cherryY);
                }
            }
            cherry.Visible = true;
            CherryTimer.Stop();
            CherryTimer.Start();
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
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>
            {
                { "up", Resources.pacman_open_up },
                { "right", Resources.pacman_open_right },
                { "down", Resources.pacman_open_down },
                { "left", Resources.pacman_open_left }
            };
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            ResetCherry();
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
            // direction wrapping
            if (svalues.DirectionWrapping)
            {
                if (pacman.Location.X < 0) // left side
                {
                    pacman.Location = new Point(GamePanel.Width, pacman.Location.Y);
                }
                else if (pacman.Location.X > GamePanel.Width) // right side
                {
                    pacman.Location = new Point(0, pacman.Location.Y);
                }
                else if (pacman.Location.Y < 0) // top side
                {
                    pacman.Location = new Point(pacman.Location.X, GamePanel.Height);
                }
                else if (pacman.Location.Y > GamePanel.Height) // bottom side
                {
                    pacman.Location = new Point(pacman.Location.X, 0);
                }
            } else
            {
                if (pacman.Location.X < 0) // left side
                {
                    pacman.Location = new Point(pacman.Location.X + svalues.PacmanSpeed, pacman.Location.Y);
                }
                else if (pacman.Location.X + 50 > GamePanel.Width) // right side, offset by the size of pacman, since location is calculated from the top left corner
                {
                    pacman.Location = new Point(pacman.Location.X - svalues.PacmanSpeed, pacman.Location.Y);
                } 
                else if (pacman.Location.Y < 0) // top side
                {
                    pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + svalues.PacmanSpeed);
                }
                else if (pacman.Location.Y + 50 > GamePanel.Height) // bottom side
                {
                    pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - svalues.PacmanSpeed);
                }
            }



            // move pacman
            if (direction == "up")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - svalues.PacmanSpeed);

            }
            else if (direction == "down")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + svalues.PacmanSpeed);
            }
            else if (direction == "left")
            {
                pacman.Location = new Point(pacman.Location.X - svalues.PacmanSpeed, pacman.Location.Y);
            }
            else if (direction == "right")
            {
                pacman.Location = new Point(pacman.Location.X + svalues.PacmanSpeed, pacman.Location.Y);
            }

            foreach (PictureBox pbox in GamePanel.Controls.OfType<PictureBox>())
            {
                if (pacman.Bounds.IntersectsWith(pbox.Bounds))
                {
                    if (pbox.Name == "cherry") // cherry 
                    {
                        score++;
                        ScoreLabel.Text = score.ToString();
                        ResetCherry();
                    }
                    else if (pbox.Name == "wall")  // wall
                    {
                        if (svalues.DeadlyWalls)
                        {
                            EndGame();
                        }
                        else
                        {
                            if (direction == "up")
                            {
                                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + svalues.PacmanSpeed); // move down
                            }
                            else if (direction == "down")
                            {
                                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - svalues.PacmanSpeed); // move up
                            }
                            else if (direction == "left")
                            {
                                pacman.Location = new Point(pacman.Location.X + svalues.PacmanSpeed, pacman.Location.Y); // move right
                            }
                            else if (direction == "right")
                            {
                                pacman.Location = new Point(pacman.Location.X - svalues.PacmanSpeed, pacman.Location.Y); // move left
                            }
                        }
                    }
                }
            }
        }


    }
}

