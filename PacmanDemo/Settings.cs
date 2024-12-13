using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanDemo
{
    public partial class Settings : Form
    {
        SettingsValues svalues;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            { 
                svalues = JsonConvert.DeserializeObject<SettingsValues>(File.ReadAllText("settings.json"));
            } 
            catch(FileNotFoundException)
            {
                svalues = new SettingsValues();
            }

            if (svalues.Preset == "easy")
            {
                Console.WriteLine("easyPicked");

                EasyRadioButton.Checked = true;
            } 
            else if (svalues.Preset == "hard")
            {
                Console.WriteLine("hardPicked");
                HardRadioButton.Checked = true;
            }
            else if (svalues.Preset == "custom")
            {
                Console.WriteLine("customPicked");
                CustomRadioButton.Checked = true;
            }
        }

        private void updateAll()
        {
            // Label values
            //GamePanelSizeLabel.Text = svalues.GamePanelSize.ToString();
            CherryRespawnRateLabel.Text = svalues.CherryRespawnTime.ToString();
            PacmanSpeedLabel.Text = svalues.PacmanSpeed.ToString();

            if (svalues.DeadlyWalls)
            {
                DeadlyWallsLabel.Text = "ON";
                DeadlyWallsLabel.ForeColor = Color.Green;
            }
            else
            {
                DeadlyWallsLabel.Text = "OFF";
                DeadlyWallsLabel.ForeColor = Color.Red;
            }

            if (svalues.DirectionWrapping)
            {
                DirectionWrappingLabel.Text = "ON";
                DirectionWrappingLabel.ForeColor = Color.Green;
            } 
            else
            {
                DirectionWrappingLabel.Text = "OFF";
                DirectionWrappingLabel.ForeColor = Color.Red;
            }


            // Disable the correct buttons
            //if (svalues.GamePanelSize == 1)
            //{
            //    GamePanelSizePlus.Enabled = true;
            //    GamePanelSizeMinus.Enabled = false;
            //}
            //else if (svalues.GamePanelSize == 3)
            //{
            //    GamePanelSizePlus.Enabled = false;
            //    GamePanelSizeMinus.Enabled = true;
            //}

            if (svalues.CherryRespawnTime == 4)
            {
                CherryRespawnRatePlus.Enabled = true;
                CherryRespawnRateMinus.Enabled = false;
            }
            else if (svalues.CherryRespawnTime == 8)
            {
                CherryRespawnRatePlus.Enabled = false;
                CherryRespawnRateMinus.Enabled = true;
            }

            if (svalues.PacmanSpeed == 2)
            {
                PacmanSpeedPlus.Enabled = true;
                PacmanSpeedMinus.Enabled = false;
            }
            else if (svalues.PacmanSpeed == 4)
            {
                PacmanSpeedPlus.Enabled = false;
                PacmanSpeedMinus.Enabled = true;
            }
        }

        //private void GamePanelSizeMinus_Click(object sender, EventArgs e)
        //{
        //    CustomRadioButton.Checked = true;
        //    if (svalues.GamePanelSize > 1)
        //    {
        //        GamePanelSizePlus.Enabled = true;
        //        svalues.GamePanelSize -= 1;
        //        GamePanelSizeLabel.Text = svalues.GamePanelSize.ToString();
        //        if (svalues.GamePanelSize == 1)
        //        {
        //            GamePanelSizeMinus.Enabled = false;
        //        }
        //    }
        //}

        //private void GamePanelSizePlus_Click(object sender, EventArgs e)
        //{
        //    CustomRadioButton.Checked = true;
        //    if (svalues.GamePanelSize < 3)
        //    {
        //        GamePanelSizeMinus.Enabled = true;
        //        svalues.GamePanelSize += 1;
        //        GamePanelSizeLabel.Text = svalues.GamePanelSize.ToString();
        //        if (svalues.GamePanelSize == 3)
        //        {
        //            GamePanelSizePlus.Enabled = false;
        //        }
        //    }

        //}

        private void CherryRespawnRateMinus_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            if (svalues.CherryRespawnTime > 4)
            {
                CherryRespawnRatePlus.Enabled = true;
                svalues.CherryRespawnTime -= 2;
                CherryRespawnRateLabel.Text = svalues.CherryRespawnTime.ToString();
                if (svalues.CherryRespawnTime == 4)
                {
                    CherryRespawnRateMinus.Enabled = false;
                }
            }
        }

        private void CherryRespawnRatePlus_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            if (svalues.CherryRespawnTime < 8)
            {
                CherryRespawnRateMinus.Enabled = true;
                svalues.CherryRespawnTime += 2;
                CherryRespawnRateLabel.Text = svalues.CherryRespawnTime.ToString();
                if (svalues.CherryRespawnTime == 8)
                {
                    CherryRespawnRatePlus.Enabled = false;
                }
            }
        }

        private void PacmanSpeedMinus_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            if (svalues.PacmanSpeed > 2)
            {
                PacmanSpeedPlus.Enabled = true;
                svalues.PacmanSpeed -= 1;
                PacmanSpeedLabel.Text = svalues.PacmanSpeed.ToString();
                if (svalues.PacmanSpeed == 2)
                {
                    PacmanSpeedMinus.Enabled = false;
                }
            }
        }

        private void PacmanSpeedPlus_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            if (svalues.PacmanSpeed < 4)
            {
                PacmanSpeedMinus.Enabled = true;
                svalues.PacmanSpeed += 1;
                PacmanSpeedLabel.Text = svalues.PacmanSpeed.ToString();
                if (svalues.PacmanSpeed == 4)
                {
                    PacmanSpeedPlus.Enabled = false;
                }
            }
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            if (EasyRadioButton.Checked)
            {
                Console.WriteLine("easy");
                svalues.Preset = "easy";
                //svalues.GamePanelSize = 1;
                svalues.CherryRespawnTime = 8;
                svalues.PacmanSpeed = 3;
                svalues.DeadlyWalls = false;
                svalues.DirectionWrapping = true;
                updateAll();
            }
            else if (HardRadioButton.Checked)
            {
                Console.WriteLine("hard");
                svalues.Preset = "hard";
                //svalues.GamePanelSize = 3;
                svalues.CherryRespawnTime = 4;
                svalues.PacmanSpeed = 2;
                svalues.DeadlyWalls = true;
                svalues.DirectionWrapping = false;
                updateAll();
            } 
            else if (CustomRadioButton.Checked)
            {
                Console.WriteLine("custom");
                svalues.Preset = "custom";
                updateAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(svalues));
            this.Dispose();
        }

        private void DirectionWrappingSwitch_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            svalues.DirectionWrapping = !svalues.DirectionWrapping;
            if (svalues.DirectionWrapping)
            {
                DirectionWrappingLabel.Text = "ON";
                DirectionWrappingLabel.ForeColor = Color.Green;
            }
            else
            {
                DirectionWrappingLabel.Text = "OFF";
                DirectionWrappingLabel.ForeColor = Color.Red;
            }
        }

        private void DeadlyWallsSwitch_Click(object sender, EventArgs e)
        {
            CustomRadioButton.Checked = true;
            svalues.DeadlyWalls = !svalues.DeadlyWalls;
            if (svalues.DeadlyWalls)
            {
                DeadlyWallsLabel.Text = "ON";
                DeadlyWallsLabel.ForeColor = Color.Green;
            }
            else
            {
                DeadlyWallsLabel.Text = "OFF";
                DeadlyWallsLabel.ForeColor = Color.Red;
            }
        }
    }

    [Serializable]
    internal class SettingsValues
    {
        public string Preset {  get; set; }
        //public int GamePanelSize {  get; set; }
        public int CherryRespawnTime { get; set; }
        public int PacmanSpeed { get; set; }
        public bool DirectionWrapping { get; set; }
        public bool DeadlyWalls { get; set; }
        public SettingsValues() 
        {
            Preset = "easy";
            //GamePanelSize = 1;
            CherryRespawnTime = 8;
            PacmanSpeed = 3;
            DeadlyWalls = false;
            DirectionWrapping = true;

        }
    }

}
