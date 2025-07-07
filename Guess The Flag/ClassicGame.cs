using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Flag
{
    public partial class ClassicGame : Form
    {
        private List<Flag> flags;
        private Flag currentFlag;
        private Random rng = new Random();
        private int score = 0;
        private int timeLeft = 60;
        private Flag previousFlag;
        private bool isSurvivalMode;
        private int correctInARow = 0;
        private int lives = 3;

        public ClassicGame(List<Flag> loadedFlags, bool isSurvivalMode)
        {
            InitializeComponent();
            flags = loadedFlags;
            this.isSurvivalMode = isSurvivalMode;

            timerTimeLeft.Interval = 1000;
            timerTimeLeft.Tick += TimerTimeLeft_Tick;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.BackColor = Color.FromArgb(210, 200, 190);

            CenterFlag();
            StartNewGame();
        }

        private void StartNewGame()
        {
            score = 0;
            timeLeft = 60;
            correctInARow = 0;
            lives = 3;

            lblTotalScore.Text = "0";
            lblTimeLeft.Text = $"Time Left: {timeLeft}s";
            lblInARow.Text = "";

            if (isSurvivalMode)
            {
                SetHeartsVisible(true);
                UpdateLivesDisplay();
            }
            else
            {
                SetHeartsVisible(false);
            }

            ShowNewFlagQuestion();
            timerTimeLeft.Start();
        }

        private void ShowNewFlagQuestion()
        {
            do
            {
                currentFlag = flags[rng.Next(flags.Count)];
            }
            while (previousFlag != null && currentFlag.CountryName == previousFlag.CountryName);

            previousFlag = currentFlag;

            List<Flag> wrongOptions = flags
                .Where(f => f != currentFlag)
                .OrderBy(x => rng.Next())
                .Take(3)
                .ToList();

            List<string> options = wrongOptions.Select(f => f.CountryName).ToList();
            options.Add(currentFlag.CountryName);
            options = options.OrderBy(x => rng.Next()).ToList();

            pictureBox1.Image = Image.FromFile(currentFlag.ImagePath);

            btnOption1.Text = options[0];
            btnOption2.Text = options[1];
            btnOption3.Text = options[2];
            btnOption4.Text = options[3];
        }

        private void TimerTimeLeft_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimeLeft.Text = $"Time Left: {timeLeft}s";

            if (timeLeft <= 0)
            {
                timerTimeLeft.Stop();
                SystemSounds.Hand.Play();

                DialogResult result = MessageBox.Show("Game Over! Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)               
                    new NewGame().Show();              
                else             
                    new Form1().Show();          

                this.Close();
            }
        }
  

        private async void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null) return;

            DisableButtons();

            SoundPlayer player;
            bool correct = clicked.Text == currentFlag.CountryName;

            if (correct)
            {
                score++;
                lblTotalScore.Text = score.ToString();
                clicked.BackColor = Color.Green;
                player = new SoundPlayer("media/correct.wav");
                player.Play();
                correctInARow++;
                if (correctInARow >= 3)
                {
                    lblInARow.Text = $"{correctInARow} correct in a row!";
                    if (correctInARow >= 15)
                        lblInARow.Text = $"Incredible! {correctInARow} in a row!";
                    CenterGuesses();
                }
            }
            else
            {
                clicked.BackColor = Color.Red;
                player = new SoundPlayer("media/wrong.wav");
                player.Play();

                correctInARow = 0;
                lblInARow.Text = "";

                if (isSurvivalMode)
                {
                    lives--;
                    UpdateLivesDisplay();

                    if (lives == 0)
                    {
                        await Task.Delay(600);
                        MessageBox.Show("You have lost all lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        new Form1().Show();
                        this.Close();
                        return;
                    }
                }
            }

            await Task.Delay(500);
            clicked.BackColor = SystemColors.Control;

            EnableButtons();
            ShowNewFlagQuestion();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid,
                Color.Black, 3, ButtonBorderStyle.Solid);
        }

        private void UpdateLivesDisplay()
        {
            string fullHeart = Path.Combine(Application.StartupPath, "bg-image", "heart.png");
            string emptyHeart = Path.Combine(Application.StartupPath, "bg-image", "emptyHeart.png");

            List<PictureBox> hearts = new List<PictureBox> { csHearts1, csHearts2, csHearts3 };

            for (int i = 0; i < hearts.Count; i++)
            {
                hearts[i].Image = Image.FromFile(i < lives ? fullHeart : emptyHeart);
            }
        }

        private void DisableButtons()
        {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void EnableButtons()
        {
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;
        }

        private void CenterFlag()
        {
            pictureBox1.Top = 60;
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        private void CenterGuesses()
        {
            lblInARow.Top = 20;
            lblInARow.Left = (this.ClientSize.Width - lblInARow.Width) / 2;
        }
        private void SetHeartsVisible(bool visible)
        {
            csHearts1.Visible = visible;
            csHearts2.Visible = visible;
            csHearts3.Visible = visible;
        }

        
    }
}
