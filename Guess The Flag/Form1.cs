using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guess_The_Flag.Properties;
using System.IO;

namespace Guess_The_Flag
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(210, 200, 190);
            lblText.BackColor = Color.Transparent;
            lblText.Top = 20;
            lblText.Left = (this.ClientSize.Width - lblText.Width) / 2;

            pboxHelp.BackColor = Color.Transparent;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            newGame.Show();       
            this.Hide();
        }      

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to quit?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
            Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
