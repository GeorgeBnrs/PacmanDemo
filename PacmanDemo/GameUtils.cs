using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacmanDemo
{
    public class GameUtils : Form
    {
        public GameUtils() 
        {

        }

        
        internal void ResetCherry(Panel GamePanel, PictureBox cherry, Timer CherryTimer)
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

        internal void EndGame(int msec, Timer GameTimer, Timer CherryTimer, Timer PacmanTimer, int score, Form ParentForm)
        {
            //
            // TODO: VARIABLE TIME
            //
            if (msec >= 1201)
            {
                GameTimer.Stop();
                CherryTimer.Stop();
                PacmanTimer.Stop();
                MessageBox.Show("Game ended, you gathered " + score.ToString() + " cherrys!");
                ParentForm.Dispose();
            }
        }

        internal void CheckCollision(Panel GamePanel, PictureBox pacman, Timer PacmanTimer,int score, Label ScoreLabel, PictureBox cherry, Timer CherryTimer, string direction)
        {
            foreach (PictureBox pbox in GamePanel.Controls.OfType<PictureBox>())
            {
                if (pacman.Bounds.IntersectsWith(pbox.Bounds))
                {
                    if (pbox.Name == "cherry") // cherry 
                    {
                        score++;
                        ScoreLabel.Text = score.ToString();
                        ResetCherry(GamePanel, cherry, CherryTimer);
                    }
                    else if (pbox.Name == "wall") // wall
                    {
                        PacmanTimer.Enabled = false;
                        // move pacman by a few pixels so he doesnt get stuck
                        if (direction == "up")
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + 2); // move down
                        }
                        else if (direction == "down")
                        {
                            pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - 2); // move up
                        }
                        else if (direction == "left")
                        {
                            pacman.Location = new Point(pacman.Location.X + 2, pacman.Location.Y); // move right
                        }
                        else if (direction == "right")
                        {
                            pacman.Location = new Point(pacman.Location.X - 2, pacman.Location.Y); // move left
                        }

                    }
                }
            }
        }
    }
}
