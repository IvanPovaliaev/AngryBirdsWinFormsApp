using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BallGame.Common
{
    public partial class SliderControl : UserControl
    {
        public event EventHandler<EventArgs> ValueChanged;
        //Fields
        private bool isMouseLeftButtonPressed;
        private Color sliderColor = Color.FromArgb(242, 196, 141);
        private int value = 0;
        public SliderControl()
        {
            InitializeComponent();
        }
        //Properties
        [Category("SliderOptions")]
        public Color SliderColor { get => sliderColor; set { valuePanel.BackColor = value; sliderColor = value;} }
        [Category("SliderOptions")]
        public int Value { get => value; set { this.value = value; UpdateValue(); } }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseLeftButtonPressed) return;
            var x = Math.Min(Math.Max(e.X, 0), Width);
            value = (100 * x) / Width;

            ValueChanged?.Invoke(this, new EventArgs());
            UpdateValue();
        }
        private void SliderControl_MouseDown(object sender, MouseEventArgs e) => isMouseLeftButtonPressed = true;
        private void SliderControl_MouseUp(object sender, MouseEventArgs e) => isMouseLeftButtonPressed = false;
        private void UpdateValue() => valuePanel.Width = Width * value / 100;

    }
}
