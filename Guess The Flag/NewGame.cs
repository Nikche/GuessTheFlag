using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Guess_The_Flag
{
    public partial class NewGame : Form
    {
        private List<Flag> flags = new List<Flag>();
        private string selectedDifficulty = null;
        private bool isSurvivalMode;

        public NewGame()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(210,200,190);
        }
        private void btnClassicGame_Click(object sender, EventArgs e)
        {
            if (rdbEasy.Checked)
            {
                selectedDifficulty = "Easy";
            }
            else if (rdbMedium.Checked) {
                selectedDifficulty = "Medium";
            }
            else if(rdbHard.Checked){
                selectedDifficulty = "Hard";
            }

            string flagsDir = null;

            if (selectedDifficulty != null)
            {
                flagsDir = Path.Combine(Application.StartupPath, "flags", selectedDifficulty);
            }
            else
            {
                MessageBox.Show("You need to select a difficulty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(flagsDir))
            {
                MessageBox.Show($"Flags folder for difficulty '{selectedDifficulty}' not found");
            }

            flags.Clear();

            var flagFiles = Directory.GetFiles(flagsDir, "*.png");

            foreach (var file in flagFiles) {
                string fileName = Path.GetFileNameWithoutExtension (file);
                string formatName = fileName.Replace('_', ' ').ToLower();
                string countryName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(formatName);
            
                flags.Add (new Flag(countryName, file));
            }

            if (cboxSurvival.Checked)
                isSurvivalMode = true;
            else        
                isSurvivalMode= false;
            


            if (rdbClassic.Checked && selectedDifficulty != null)
            {
                    ClassicGame classicGame = new ClassicGame(flags, isSurvivalMode);
                    classicGame.Show();
                    this.Close();
            }
            else if (rdbInverted.Checked && selectedDifficulty != null)
            {
                    invertedGame invGame = new invertedGame(flags, isSurvivalMode);
                    invGame.Show();
                    this.Close();
            }
            else
            {
                MessageBox.Show("You have to select a Game Mode in order to play!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
