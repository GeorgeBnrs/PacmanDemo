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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GamePanelSizeLabel = new System.Windows.Forms.Label();
            this.GamePanelSizePlus = new System.Windows.Forms.Button();
            this.GamePanelSizeMinus = new System.Windows.Forms.Button();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.sep1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Panel Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GamePanelSizeLabel
            // 
            this.GamePanelSizeLabel.AutoSize = true;
            this.GamePanelSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelSizeLabel.Location = new System.Drawing.Point(54, 194);
            this.GamePanelSizeLabel.Name = "GamePanelSizeLabel";
            this.GamePanelSizeLabel.Size = new System.Drawing.Size(20, 24);
            this.GamePanelSizeLabel.TabIndex = 4;
            this.GamePanelSizeLabel.Text = "0";
            // 
            // GamePanelSizePlus
            // 
            this.GamePanelSizePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelSizePlus.Location = new System.Drawing.Point(80, 190);
            this.GamePanelSizePlus.Name = "GamePanelSizePlus";
            this.GamePanelSizePlus.Size = new System.Drawing.Size(35, 35);
            this.GamePanelSizePlus.TabIndex = 5;
            this.GamePanelSizePlus.Text = "+";
            this.GamePanelSizePlus.UseVisualStyleBackColor = true;
            this.GamePanelSizePlus.Click += new System.EventHandler(this.checkCustom);
            // 
            // GamePanelSizeMinus
            // 
            this.GamePanelSizeMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelSizeMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GamePanelSizeMinus.Location = new System.Drawing.Point(12, 190);
            this.GamePanelSizeMinus.Name = "GamePanelSizeMinus";
            this.GamePanelSizeMinus.Size = new System.Drawing.Size(35, 35);
            this.GamePanelSizeMinus.TabIndex = 6;
            this.GamePanelSizeMinus.Text = "-";
            this.GamePanelSizeMinus.UseVisualStyleBackColor = true;
            this.GamePanelSizeMinus.Click += new System.EventHandler(this.checkCustom);
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
            // sep1
            // 
            this.sep1.AutoSize = true;
            this.sep1.Location = new System.Drawing.Point(12, 142);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(214, 13);
            this.sep1.TabIndex = 9;
            this.sep1.Text = "---------------------------------------------------------------------";
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
            this.sep2.Location = new System.Drawing.Point(12, 245);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(214, 13);
            this.sep2.TabIndex = 16;
            this.sep2.Text = "---------------------------------------------------------------------";
            // 
            // CherryRespawnRateMinus
            // 
            this.CherryRespawnRateMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRateMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CherryRespawnRateMinus.Location = new System.Drawing.Point(12, 293);
            this.CherryRespawnRateMinus.Name = "CherryRespawnRateMinus";
            this.CherryRespawnRateMinus.Size = new System.Drawing.Size(35, 35);
            this.CherryRespawnRateMinus.TabIndex = 15;
            this.CherryRespawnRateMinus.Text = "-";
            this.CherryRespawnRateMinus.UseVisualStyleBackColor = true;
            this.CherryRespawnRateMinus.Click += new System.EventHandler(this.checkCustom);
            // 
            // CherryRespawnRatePlus
            // 
            this.CherryRespawnRatePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRatePlus.Location = new System.Drawing.Point(80, 293);
            this.CherryRespawnRatePlus.Name = "CherryRespawnRatePlus";
            this.CherryRespawnRatePlus.Size = new System.Drawing.Size(35, 35);
            this.CherryRespawnRatePlus.TabIndex = 14;
            this.CherryRespawnRatePlus.Text = "+";
            this.CherryRespawnRatePlus.UseVisualStyleBackColor = true;
            this.CherryRespawnRatePlus.Click += new System.EventHandler(this.checkCustom);
            // 
            // CherryRespawnRateLabel
            // 
            this.CherryRespawnRateLabel.AutoSize = true;
            this.CherryRespawnRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryRespawnRateLabel.Location = new System.Drawing.Point(54, 297);
            this.CherryRespawnRateLabel.Name = "CherryRespawnRateLabel";
            this.CherryRespawnRateLabel.Size = new System.Drawing.Size(20, 24);
            this.CherryRespawnRateLabel.TabIndex = 13;
            this.CherryRespawnRateLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cherry Respawn Rate (sec)";
            // 
            // sep3
            // 
            this.sep3.AutoSize = true;
            this.sep3.Location = new System.Drawing.Point(12, 345);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(214, 13);
            this.sep3.TabIndex = 21;
            this.sep3.Text = "---------------------------------------------------------------------";
            // 
            // PacmanSpeedMinus
            // 
            this.PacmanSpeedMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PacmanSpeedMinus.Location = new System.Drawing.Point(12, 393);
            this.PacmanSpeedMinus.Name = "PacmanSpeedMinus";
            this.PacmanSpeedMinus.Size = new System.Drawing.Size(35, 35);
            this.PacmanSpeedMinus.TabIndex = 20;
            this.PacmanSpeedMinus.Text = "-";
            this.PacmanSpeedMinus.UseVisualStyleBackColor = true;
            this.PacmanSpeedMinus.Click += new System.EventHandler(this.checkCustom);
            // 
            // PacmanSpeedPlus
            // 
            this.PacmanSpeedPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedPlus.Location = new System.Drawing.Point(90, 393);
            this.PacmanSpeedPlus.Name = "PacmanSpeedPlus";
            this.PacmanSpeedPlus.Size = new System.Drawing.Size(35, 35);
            this.PacmanSpeedPlus.TabIndex = 19;
            this.PacmanSpeedPlus.Text = "+";
            this.PacmanSpeedPlus.UseVisualStyleBackColor = true;
            this.PacmanSpeedPlus.Click += new System.EventHandler(this.checkCustom);
            // 
            // PacmanSpeedLabel
            // 
            this.PacmanSpeedLabel.AutoSize = true;
            this.PacmanSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanSpeedLabel.Location = new System.Drawing.Point(54, 397);
            this.PacmanSpeedLabel.Name = "PacmanSpeedLabel";
            this.PacmanSpeedLabel.Size = new System.Drawing.Size(30, 24);
            this.PacmanSpeedLabel.TabIndex = 18;
            this.PacmanSpeedLabel.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 370);
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 652);
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
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.GamePanelSizeMinus);
            this.Controls.Add(this.GamePanelSizePlus);
            this.Controls.Add(this.GamePanelSizeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GamePanelSizeLabel;
        private System.Windows.Forms.Button GamePanelSizePlus;
        private System.Windows.Forms.Button GamePanelSizeMinus;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.Label sep1;
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
    }
}