namespace PacmanDemo
{
    partial class Settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomRadioButton = new System.Windows.Forms.RadioButton();
            this.sep2 = new System.Windows.Forms.Label();
            this.CherryRespawnRateMinus = new System.Windows.Forms.Button();
            this.CherryRespawnRatePlus = new System.Windows.Forms.Button();
            this.CherryRespawnRateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sep3 = new System.Windows.Forms.Label();
            this.PacmanSpeedMinus = new System.Windows.Forms.Button();
            this.PacmanSpeedPlus = new System.Windows.Forms.Button();
            this.PacmanSpeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DirectionWrappingSwitch = new System.Windows.Forms.Button();
            this.DirectionWrappingLabel = new System.Windows.Forms.Label();
            this.DeadlyWallsLabel = new System.Windows.Forms.Label();
            this.DeadlyWallsSwitch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyRadioButton.Location = new System.Drawing.Point(18, 52);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(56, 20);
            this.EasyRadioButton.TabIndex = 7;
            this.EasyRadioButton.Text = "Easy";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            this.EasyRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardRadioButton.Location = new System.Drawing.Point(18, 75);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(55, 20);
            this.HardRadioButton.TabIndex = 8;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Text = "Hard";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            this.HardRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Configuration Preset";
            // 
            // CustomRadioButton
            // 
            this.CustomRadioButton.AutoSize = true;
            this.CustomRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRadioButton.Location = new System.Drawing.Point(18, 101);
            this.CustomRadioButton.Name = "CustomRadioButton";
            this.CustomRadioButton.Size = new System.Drawing.Size(70, 20);
            this.CustomRadioButton.TabIndex = 11;
            this.CustomRadioButton.TabStop = true;
            this.CustomRadioButton.Text = "Custom";
            this.CustomRadioButton.UseVisualStyleBackColor = true;
            this.CustomRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // sep2
            // 
            this.sep2.AutoSize = true;
            this.sep2.Location = new System.Drawing.Point(12, 134);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(214, 13);
            this.sep2.TabIndex = 16;
            this.sep2.Text = "---------------------------------------------------------------------";
            // 
            // CherryRespawnRateMinus
            // 
            this.CherryRespawnRateMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRateMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CherryRespawnRateMinus.Location = new System.Drawing.Point(12, 182);
            this.CherryRespawnRateMinus.Name = "CherryRespawnRateMinus";
            this.CherryRespawnRateMinus.Size = new System.Drawing.Size(35, 35);
            this.CherryRespawnRateMinus.TabIndex = 15;
            this.CherryRespawnRateMinus.Text = "-";
            this.CherryRespawnRateMinus.UseVisualStyleBackColor = true;
            this.CherryRespawnRateMinus.Click += new System.EventHandler(this.CherryRespawnRateMinus_Click);
            // 
            // CherryRespawnRatePlus
            // 
            this.CherryRespawnRatePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRatePlus.Location = new System.Drawing.Point(80, 182);
            this.CherryRespawnRatePlus.Name = "CherryRespawnRatePlus";
            this.CherryRespawnRatePlus.Size = new System.Drawing.Size(35, 35);
            this.CherryRespawnRatePlus.TabIndex = 14;
            this.CherryRespawnRatePlus.Text = "+";
            this.CherryRespawnRatePlus.UseVisualStyleBackColor = true;
            this.CherryRespawnRatePlus.Click += new System.EventHandler(this.CherryRespawnRatePlus_Click);
            // 
            // CherryRespawnRateLabel
            // 
            this.CherryRespawnRateLabel.AutoSize = true;
            this.CherryRespawnRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRateLabel.Location = new System.Drawing.Point(54, 186);
            this.CherryRespawnRateLabel.Name = "CherryRespawnRateLabel";
            this.CherryRespawnRateLabel.Size = new System.Drawing.Size(20, 24);
            this.CherryRespawnRateLabel.TabIndex = 13;
            this.CherryRespawnRateLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cherry Respawn Rate (sec)";
            // 
            // sep3
            // 
            this.sep3.AutoSize = true;
            this.sep3.Location = new System.Drawing.Point(12, 234);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(214, 13);
            this.sep3.TabIndex = 21;
            this.sep3.Text = "---------------------------------------------------------------------";
            // 
            // PacmanSpeedMinus
            // 
            this.PacmanSpeedMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PacmanSpeedMinus.Location = new System.Drawing.Point(12, 282);
            this.PacmanSpeedMinus.Name = "PacmanSpeedMinus";
            this.PacmanSpeedMinus.Size = new System.Drawing.Size(35, 35);
            this.PacmanSpeedMinus.TabIndex = 20;
            this.PacmanSpeedMinus.Text = "-";
            this.PacmanSpeedMinus.UseVisualStyleBackColor = true;
            this.PacmanSpeedMinus.Click += new System.EventHandler(this.PacmanSpeedMinus_Click);
            // 
            // PacmanSpeedPlus
            // 
            this.PacmanSpeedPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedPlus.Location = new System.Drawing.Point(80, 284);
            this.PacmanSpeedPlus.Name = "PacmanSpeedPlus";
            this.PacmanSpeedPlus.Size = new System.Drawing.Size(35, 35);
            this.PacmanSpeedPlus.TabIndex = 19;
            this.PacmanSpeedPlus.Text = "+";
            this.PacmanSpeedPlus.UseVisualStyleBackColor = true;
            this.PacmanSpeedPlus.Click += new System.EventHandler(this.PacmanSpeedPlus_Click);
            // 
            // PacmanSpeedLabel
            // 
            this.PacmanSpeedLabel.AutoSize = true;
            this.PacmanSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedLabel.Location = new System.Drawing.Point(54, 286);
            this.PacmanSpeedLabel.Name = "PacmanSpeedLabel";
            this.PacmanSpeedLabel.Size = new System.Drawing.Size(20, 24);
            this.PacmanSpeedLabel.TabIndex = 18;
            this.PacmanSpeedLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pacman Speed";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(296, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(365, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "InvisibleDefaultRadioButtonSoCorrectRadioButtonGetsCheckedOnLoad";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "---------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Direction Wrapping";
            // 
            // DirectionWrappingSwitch
            // 
            this.DirectionWrappingSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionWrappingSwitch.Location = new System.Drawing.Point(61, 399);
            this.DirectionWrappingSwitch.Name = "DirectionWrappingSwitch";
            this.DirectionWrappingSwitch.Size = new System.Drawing.Size(35, 35);
            this.DirectionWrappingSwitch.TabIndex = 25;
            this.DirectionWrappingSwitch.Text = "↔";
            this.DirectionWrappingSwitch.UseVisualStyleBackColor = true;
            this.DirectionWrappingSwitch.Click += new System.EventHandler(this.DirectionWrappingSwitch_Click);
            // 
            // DirectionWrappingLabel
            // 
            this.DirectionWrappingLabel.AutoSize = true;
            this.DirectionWrappingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionWrappingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DirectionWrappingLabel.Location = new System.Drawing.Point(18, 406);
            this.DirectionWrappingLabel.Name = "DirectionWrappingLabel";
            this.DirectionWrappingLabel.Size = new System.Drawing.Size(32, 20);
            this.DirectionWrappingLabel.TabIndex = 26;
            this.DirectionWrappingLabel.Text = "ON";
            // 
            // DeadlyWallsLabel
            // 
            this.DeadlyWallsLabel.AutoSize = true;
            this.DeadlyWallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlyWallsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadlyWallsLabel.Location = new System.Drawing.Point(18, 523);
            this.DeadlyWallsLabel.Name = "DeadlyWallsLabel";
            this.DeadlyWallsLabel.Size = new System.Drawing.Size(41, 20);
            this.DeadlyWallsLabel.TabIndex = 30;
            this.DeadlyWallsLabel.Text = "OFF";
            // 
            // DeadlyWallsSwitch
            // 
            this.DeadlyWallsSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlyWallsSwitch.Location = new System.Drawing.Point(61, 516);
            this.DeadlyWallsSwitch.Name = "DeadlyWallsSwitch";
            this.DeadlyWallsSwitch.Size = new System.Drawing.Size(35, 35);
            this.DeadlyWallsSwitch.TabIndex = 29;
            this.DeadlyWallsSwitch.Text = "↔";
            this.DeadlyWallsSwitch.UseVisualStyleBackColor = true;
            this.DeadlyWallsSwitch.Click += new System.EventHandler(this.DeadlyWallsSwitch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Deadly Walls";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "---------------------------------------------------------------------";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 767);
            this.Controls.Add(this.DeadlyWallsLabel);
            this.Controls.Add(this.DeadlyWallsSwitch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DirectionWrappingLabel);
            this.Controls.Add(this.DirectionWrappingSwitch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.sep3);
            this.Controls.Add(this.PacmanSpeedMinus);
            this.Controls.Add(this.PacmanSpeedPlus);
            this.Controls.Add(this.PacmanSpeedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.CherryRespawnRateMinus);
            this.Controls.Add(this.CherryRespawnRatePlus);
            this.Controls.Add(this.CherryRespawnRateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.button1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton CustomRadioButton;
        private System.Windows.Forms.Label sep2;
        private System.Windows.Forms.Button CherryRespawnRateMinus;
        private System.Windows.Forms.Button CherryRespawnRatePlus;
        private System.Windows.Forms.Label CherryRespawnRateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sep3;
        private System.Windows.Forms.Button PacmanSpeedMinus;
        private System.Windows.Forms.Button PacmanSpeedPlus;
        private System.Windows.Forms.Label PacmanSpeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DirectionWrappingSwitch;
        private System.Windows.Forms.Label DirectionWrappingLabel;
        private System.Windows.Forms.Label DeadlyWallsLabel;
        private System.Windows.Forms.Button DeadlyWallsSwitch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}