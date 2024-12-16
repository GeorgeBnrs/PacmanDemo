using PacmanDemo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanDemo
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            this.Text = "Pacman Game Launcher";
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Play_Pressed;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Play2;
            new Game().ShowDialog();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.Config_Pressed;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.Config;
            new Settings().ShowDialog();
        }
    }
}
