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
        SettingsValues svalues;

        public Game()
        {
            InitializeComponent();
            Text = "Pacman";
            FormClosing += Game_Closing;
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // rename all walls to "wall", since this isn't supported by the designer
            foreach (PictureBox wall in GamePanel.Controls.OfType<PictureBox>())
            {
                if ((wall.Name != "cherry") && (wall.Name != "pacman"))
                {
                    wall.Name = "wall";
                }
            }
            
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

        private void Game_Closing(object sender, EventArgs e)
        {
            Dispose();
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
            UpdateTimer(msec);
            UpdateImage();
        }

        private void EndGame()
        {
            GameTimer.Stop();
            CherryTimer.Stop();
            PacmanTimer.Stop();
            MessageBox.Show("Game ended, you gathered " + score.ToString() + " cherries!");
            Dispose();
        }

        private void ResetCherry()
        {
            Random rnd = new Random();
            int cherryX = rnd.Next(GamePanel.Width - 32); // - 32 so it doesn't appear outside the panel sometimes, since the location is of the top left corner 
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

        private void UpdateTimer(int msec)
        {
            int mins = msec / 600;
            int secs = msec / 10 - (mins * 60);
            int msecs = msec - (mins * 600) - (secs * 10);
            GameTimerLabel.Text = mins.ToString() + " : " + secs.ToString() + " : " + msecs.ToString();
        }

        private void UpdateImage()
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

        private void CherryTimer_Tick(object sender, EventArgs e)
        {
            ResetCherry();
        }

        private void MovePacman(string direction, int distance)
        {
            if (direction == "up")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - distance);
            } 
            else if (direction == "down")
            {
                pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + distance);
            }
            else if (direction == "left")
            {
                pacman.Location = new Point(pacman.Location.X - distance, pacman.Location.Y);
            }
            else if (direction == "right")
            {
                pacman.Location = new Point(pacman.Location.X + distance, pacman.Location.Y);
            }
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
            // direction wrapping
            if (svalues.DirectionWrapping)
            {
                // Move to the opposite side
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
                // Stop pacman
                if (pacman.Location.X < 0) // left side
                {
                    MovePacman("right", svalues.PacmanSpeed);
                }
                else if (pacman.Location.X + 50 > GamePanel.Width) // right side, offset by the size of pacman, since location is calculated from the top left corner
                {
                    MovePacman("left", svalues.PacmanSpeed);
                } 
                else if (pacman.Location.Y < 0) // top side
                {
                    MovePacman("down", svalues.PacmanSpeed);
                }
                else if (pacman.Location.Y + 50 > GamePanel.Height) // bottom side
                {
                    MovePacman("up", svalues.PacmanSpeed);
                }
            }



            // move pacman
            MovePacman(direction, svalues.PacmanSpeed);

            foreach (PictureBox pbox in GamePanel.Controls.OfType<PictureBox>())
            {
                if (pacman.Bounds.IntersectsWith(pbox.Bounds))
                {
                    if (pbox.Name == "cherry") // capture cherry 
                    {
                        score++;
                        ScoreLabel.Text = "Score: " +score.ToString();
                        ResetCherry();
                    }
                    else if (pbox.Name == "wall") // 
                    {
                        if (svalues.DeadlyWalls)
                        {
                            EndGame();
                        }
                        else // "Stop" pacman when hitting a wall
                        {
                            if (direction == "up")
                            {
                                MovePacman("down", svalues.PacmanSpeed);
                            }
                            else if (direction == "down")
                            {
                                MovePacman("up", svalues.PacmanSpeed);
                            }
                            else if (direction == "left")
                            {
                                MovePacman("right", svalues.PacmanSpeed);
                            }
                            else if (direction == "right")
                            {
                                MovePacman("left", svalues.PacmanSpeed);
                            }
                        }
                    }
                }
            }
        }
    }
}

