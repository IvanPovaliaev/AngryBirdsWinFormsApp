namespace AngryBirdsWinForms
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            scoreLabel = new System.Windows.Forms.Label();
            settingsButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = System.Drawing.Color.Transparent;
            scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            scoreLabel.ForeColor = System.Drawing.Color.Black;
            scoreLabel.Location = new System.Drawing.Point(21, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(81, 24);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "Счёт: 0";
            // 
            // settingsButton
            // 
            settingsButton.BackColor = System.Drawing.Color.Transparent;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            settingsButton.Location = new System.Drawing.Point(1059, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new System.Drawing.Size(113, 30);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = Properties.Resources.gameBackGround;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1184, 681);
            Controls.Add(settingsButton);
            Controls.Add(scoreLabel);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1184, 681);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1184, 681);
            Name = "GameForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AngryBirds";
            FormClosed += GameForm_FormClosed;
            Load += GameForm_Load;
            Paint += GameForm_Paint;
            MouseDown += GameForm_MouseDown;
            MouseMove += GameForm_MouseMove;
            MouseUp += GameForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button settingsButton;
    }
}
