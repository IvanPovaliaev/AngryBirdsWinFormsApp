namespace BallGame.Common
{
    partial class SliderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            valuePanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // valuePanel
            // 
            valuePanel.BackColor = System.Drawing.Color.FromArgb(242, 196, 141);
            valuePanel.Dock = System.Windows.Forms.DockStyle.Left;
            valuePanel.Location = new System.Drawing.Point(0, 0);
            valuePanel.Name = "valuePanel";
            valuePanel.Size = new System.Drawing.Size(28, 18);
            valuePanel.TabIndex = 0;
            valuePanel.MouseDown += SliderControl_MouseDown;
            valuePanel.MouseMove += UserControl1_MouseMove;
            valuePanel.MouseUp += SliderControl_MouseUp;
            // 
            // SliderControl
            // 
            Controls.Add(valuePanel);
            Name = "SliderControl";
            Size = new System.Drawing.Size(150, 18);
            MouseDown += SliderControl_MouseDown;
            MouseMove += UserControl1_MouseMove;
            MouseUp += SliderControl_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel valuePanel;
    }
}
