namespace AngryBirdsWinForms
{
    partial class SettingsForm
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
            soundVolumeSliderControl = new BallGame.Common.SliderControl();
            soundsLevelLabel = new System.Windows.Forms.Label();
            soundCurrentVolumeLabel = new System.Windows.Forms.Label();
            acceptButton = new System.Windows.Forms.Button();
            fileLanguageComboBox = new System.Windows.Forms.ComboBox();
            languageLabel = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // soundVolumeSliderControl
            // 
            soundVolumeSliderControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            soundVolumeSliderControl.Location = new System.Drawing.Point(416, 339);
            soundVolumeSliderControl.Name = "soundVolumeSliderControl";
            soundVolumeSliderControl.Size = new System.Drawing.Size(366, 30);
            soundVolumeSliderControl.SliderColor = System.Drawing.Color.FromArgb(240, 204, 189);
            soundVolumeSliderControl.TabIndex = 0;
            soundVolumeSliderControl.Value = 60;
            // 
            // soundsLevelLabel
            // 
            soundsLevelLabel.BackColor = System.Drawing.Color.Transparent;
            soundsLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            soundsLevelLabel.ForeColor = System.Drawing.Color.FromArgb(46, 31, 47);
            soundsLevelLabel.Location = new System.Drawing.Point(416, 286);
            soundsLevelLabel.Name = "soundsLevelLabel";
            soundsLevelLabel.Size = new System.Drawing.Size(366, 50);
            soundsLevelLabel.TabIndex = 1;
            soundsLevelLabel.Text = "Громкость звуков";
            soundsLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundCurrentVolumeLabel
            // 
            soundCurrentVolumeLabel.AutoSize = true;
            soundCurrentVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            soundCurrentVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            soundCurrentVolumeLabel.ForeColor = System.Drawing.Color.Black;
            soundCurrentVolumeLabel.Location = new System.Drawing.Point(567, 372);
            soundCurrentVolumeLabel.Name = "soundCurrentVolumeLabel";
            soundCurrentVolumeLabel.Size = new System.Drawing.Size(59, 26);
            soundCurrentVolumeLabel.TabIndex = 6;
            soundCurrentVolumeLabel.Text = "30%";
            soundCurrentVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            acceptButton.BackColor = System.Drawing.Color.Transparent;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            acceptButton.ForeColor = System.Drawing.Color.White;
            acceptButton.Location = new System.Drawing.Point(1054, 624);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(118, 45);
            acceptButton.TabIndex = 7;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // fileLanguageComboBox
            // 
            fileLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fileLanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fileLanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            fileLanguageComboBox.FormattingEnabled = true;
            fileLanguageComboBox.Items.AddRange(new object[] { "Русский", "English" });
            fileLanguageComboBox.Location = new System.Drawing.Point(416, 479);
            fileLanguageComboBox.Name = "fileLanguageComboBox";
            fileLanguageComboBox.Size = new System.Drawing.Size(366, 28);
            fileLanguageComboBox.TabIndex = 8;
            fileLanguageComboBox.SelectedIndexChanged += fileLanguageComboBox_SelectedIndexChanged;
            // 
            // languageLabel
            // 
            languageLabel.BackColor = System.Drawing.Color.Transparent;
            languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            languageLabel.ForeColor = System.Drawing.Color.FromArgb(46, 31, 47);
            languageLabel.Location = new System.Drawing.Point(416, 426);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new System.Drawing.Size(366, 50);
            languageLabel.TabIndex = 1;
            languageLabel.Text = "Язык";
            languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cancelButton.BackColor = System.Drawing.Color.Transparent;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            cancelButton.ForeColor = System.Drawing.Color.White;
            cancelButton.Location = new System.Drawing.Point(930, 624);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(118, 45);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.settingsBackGround;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1184, 681);
            Controls.Add(fileLanguageComboBox);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(soundCurrentVolumeLabel);
            Controls.Add(languageLabel);
            Controls.Add(soundsLevelLabel);
            Controls.Add(soundVolumeSliderControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1184, 681);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1184, 681);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BallGame.Common.SliderControl soundVolumeSliderControl;
        private System.Windows.Forms.Label soundsLevelLabel;
        private System.Windows.Forms.Label soundCurrentVolumeLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ComboBox fileLanguageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}