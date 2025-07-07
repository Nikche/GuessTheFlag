using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


namespace Guess_The_Flag
{
    public partial class invertedGame : Form
    {
        private List<Flag> flags;
        private int score = 0;
        private int timeLeft = 60;
        private Flag correctFlag;
        private Random rng = new Random();
        private List<PictureBox> pictureBoxes;
        private Flag previousFlag;
        private bool isSurvivalMode;
        private int correctInARow = 0;
        private int lives = 3;

        public invertedGame(List<Flag> loadedFlags, bool isSurvivalMode)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(210, 200, 190);

            flags = loadedFlags;
            this.isSurvivalMode = isSurvivalMode;

            SetupPictureBoxes();
            StartNewGame();
            
        }
        private void StartNewGame()
        {
            score = 0;
            timeLeft = 60;
            lblScore.Text = "0";
            lblTimeLeft.Text = $"Time Left: {timeLeft}s";

            ShowNewFlagQuestion();
            timerInvGame.Start();

            if (isSurvivalMode)
            {
                SetHeartsVisible(true);
                UpdateLivesDisplay();
            }
            else
            {
                SetHeartsVisible(false);
            }
        }
        private void ShowNewFlagQuestion()
        {
            if (flags.Count < 4)
            {
                MessageBox.Show("Not enough flags remaining.");
                return;
            }

            List<Flag> current = flags.OrderBy(x => rng.Next()).Take(4).ToList();
            do
            {
                correctFlag = current[rng.Next(4)];
            }
            while (previousFlag != null && correctFlag.CountryName == previousFlag.CountryName);

            previousFlag = correctFlag;

            lblCountryName.Text = correctFlag.CountryName;
            CenterCountryLabel();

            List<PictureBox> pictureBoxes = new List<PictureBox> { pbox1, pbox2, pbox3, pbox4 };
            for (int i = 0; i < 4; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(current[i].ImagePath);
                pictureBoxes[i].Tag = current[i];
            }
        }

        private void timerInvGame_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimeLeft.Text = $"Time Left: {timeLeft}s";

            if (timeLeft <= 0)
            {
                timerInvGame.Stop();

                SystemSounds.Exclamation.Play();

                DialogResult result = MessageBox.Show("Game Over! Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    NewGame ng = new NewGame();
                    ng.Show();
                    this.Close();
                }
                else
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Close();
                }

                this.Close();
            }
        }
        private void SetupPictureBoxes()
        {
            pictureBoxes = new List<PictureBox> { pbox1, pbox2, pbox3, pbox4 };

            foreach (var pbox in pictureBoxes)
            {
                pbox.SizeMode = PictureBoxSizeMode.Zoom;
                pbox.Paint += DrawBlackBorder;
                pbox.Click += Flag_Click;
            }

            timerInvGame.Stop();
            timerInvGame.Tick -= timerInvGame_Tick;
            timerInvGame.Tick += timerInvGame_Tick;
            timerInvGame.Interval = 1000;
        }

        private async void Flag_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            Flag selectedFlag = clicked.Tag as Flag;

            if (selectedFlag == null) return;

            foreach (var pictureBox in pictureBoxes)
                pictureBox.Enabled = false;

            SoundPlayer player;

            if (selectedFlag.CountryName == correctFlag.CountryName)
            {
                score++;
                lblScore.Text = score.ToString();
                player = new SoundPlayer("media/correct.wav");
                player.Play();
                correctInARow++;
            }
            else
            {
                correctInARow = 0;
                player = new SoundPlayer("media/wrong.wav");
                player.Play();

                if (isSurvivalMode)
                {
                    lives--;
                    UpdateLivesDisplay();

                    if (lives <= 0)
                    {
                        MessageBox.Show("You have lost all your lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form1 f = new Form1();
                        f.Show();
                        this.Close();
                        return;
                    }
                }
            }

            await Task.Delay(500);
            clicked.BackColor = Color.Transparent;

            foreach (var pictureBox in pictureBoxes)
                pictureBox.Enabled = true;

            ShowNewFlagQuestion();
        }

        private void DrawBlackBorder(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid);
        }
        

        private void SetHeartsVisible(bool visible)
        {
            invHearts1.Visible = visible;
            invHearts2.Visible = visible;
            invHearts3.Visible = visible;
        }

        private void UpdateLivesDisplay()
        {
            string fullHeart = Path.Combine(Application.StartupPath, "bg-image", "heart.png");
            string emptyHeart = Path.Combine(Application.StartupPath, "bg-image", "emptyHeart.png");

            List<PictureBox> hearts = new List<PictureBox> { invHearts1, invHearts2, invHearts3 };

            for (int i = 0; i < hearts.Count; i++)
            {
                hearts[i].Image = Image.FromFile(i < lives ? fullHeart : emptyHeart);
            }
        }

        private void CenterCountryLabel()
        {
            lblCountryName.Top = 20;
            lblCountryName.Left = (this.ClientSize.Width - lblCountryName.Width) / 2;
        }
    }

}
