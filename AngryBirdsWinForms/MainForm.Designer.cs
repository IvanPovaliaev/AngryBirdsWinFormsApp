namespace AngryBirdsWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            childFormPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.BackColor = System.Drawing.Color.NavajoWhite;
            resources.ApplyResources(childFormPanel, "childFormPanel");
            childFormPanel.Name = "childFormPanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(childFormPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel childFormPanel;
    }
}