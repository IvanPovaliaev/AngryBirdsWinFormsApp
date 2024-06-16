using BallGame.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public partial class GameForm : Form
    {
        private Timer refreshTimer;
        private System.Timers.Timer checkHitTimer;
        private bool isMouseLeftButtonPressed;
        private bool isBirdMoved;
        private bool isPigHitted;
        private Bird bird;
        private Pig pig;
        private PointF currentDirectionLocation;
        private int score;
        private int aimingRadius = 250;
        private int soundsVolume;

        public GameForm()
        {
            InitializeComponent();
            soundsVolume = SystemSettings.SoundsVolume;
            InitializeComponentsText();
        }

        private void InitializeComponentsText()
        {
            var localizationResManager = SystemSettings.LocalizationResourceManager;
            scoreLabel.Text = $"{localizationResManager.GetString("Score")}: {score}";
            settingsButton.Text = localizationResManager.GetString("SettingsButton");
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            InitializeRefreshTimer();
            CreatePig();
            CreateBird();
            InitializeCheckHitTimer();
        }
        private void CreateBird()
        {
            isBirdMoved = false;
            bird = new ElasticGravityBird(this);
            bird.AddDissapearEvent((sender, e) =>
            {
                if (!isPigHitted) _ = AudioProvider.PlaySoundAsync(Pig.MockertySoundPath, soundsVolume);
                CreateBird();
            });
        }
        private void CreatePig()
        {
            pig = new RandomPointPig(this);
            isPigHitted = false;
        }
        private void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5;
            refreshTimer.Tick += (sender, e) => Invalidate();
            refreshTimer.Start();
        }
        private void InitializeCheckHitTimer()
        {
            checkHitTimer = new System.Timers.Timer();
            checkHitTimer.Interval = 5;
            checkHitTimer.Elapsed += CheckHitTimer_Elapsed;
            checkHitTimer.Start();
        }
        private void CheckHitTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (bird.GetBounds().IntersectsWith(pig.GetBounds()))
            {
                _ = AudioProvider.PlaySoundAsync(Pig.HittedSoundPath, soundsVolume);
                isPigHitted = true;
                bird.Stop();
                CreatePig();
                Invoke(IncreaseScore);
            }
        }
        private void IncreaseScore()
        {
            score++;
            scoreLabel.Text = $"{SystemSettings.LocalizationResourceManager.GetString("Score")}: {score}";
        }
        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if (isMouseLeftButtonPressed && !isBirdMoved)
            {
                var brush = new SolidBrush(Color.FromArgb(175, Color.White));
                var pen = new Pen(brush, 30f);
                e.Graphics.DrawLine(pen, bird.GetCenterPoint(), GetEndDirectionPointF());
            }
            e.Graphics.DrawImage(pig.GetImage(), pig.GetBounds());
            e.Graphics.DrawImage(bird.GetImage(), bird.GetBounds());
        }
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseLeftButtonPressed)
                currentDirectionLocation = e.Location;
        }
        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isBirdMoved)
                {
                    _ = AudioProvider.PlaySoundAsync(SoundEffects.AimingSound, soundsVolume);
                }
                isMouseLeftButtonPressed = true;
            }
        }
        private void GameForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseLeftButtonPressed && !isBirdMoved)
            {
                _ = AudioProvider.PlaySoundAsync(SoundEffects.ThrowSound, soundsVolume);

                bird?.SetVelocity(GetEndDirectionPointF());
                isBirdMoved = true;
                _ = AudioProvider.PlaySoundAsync(Bird.ThrowSoundPath, soundsVolume);
                bird?.Start();
            }
            isMouseLeftButtonPressed = false;
        }
        private PointF GetEndDirectionPointF()
        {
            var startPoint = bird.GetCenterPoint();
            var xLength = currentDirectionLocation.X - startPoint.X;
            var yLength = startPoint.Y - currentDirectionLocation.Y;
            var currentRadius = Math.Sqrt(Math.Pow(xLength, 2) + Math.Pow(yLength, 2));

            if (currentRadius > aimingRadius)
            {
                var directionSin = yLength / currentRadius;
                var directionCos = xLength / currentRadius;

                var limitX = startPoint.X + aimingRadius * directionCos;
                var limitY = startPoint.Y - aimingRadius * directionSin;

                return new PointF((float)limitX, (float)limitY);
            }
            return currentDirectionLocation;
        }
        private void settingsButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new SettingsForm());
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isPigHitted = true;
            bird.Stop();
        }
    }
}
