namespace Guess_The_Flag
{
    partial class invertedGame
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.timerInvGame = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invHearts3 = new System.Windows.Forms.PictureBox();
            this.invHearts2 = new System.Windows.Forms.PictureBox();
            this.invHearts1 = new System.Windows.Forms.PictureBox();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.invHearts3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invHearts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invHearts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(112, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 6;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(356, 31);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(0, 28);
            this.lblCountryName.TabIndex = 11;
            // 
            // timerInvGame
            // 
            this.timerInvGame.Tick += new System.EventHandler(this.timerInvGame_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(653, 9);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(79, 20);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Score:";
            // 
            // invHearts3
            // 
            this.invHearts3.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.invHearts3.Location = new System.Drawing.Point(88, 32);
            this.invHearts3.Name = "invHearts3";
            this.invHearts3.Size = new System.Drawing.Size(32, 32);
            this.invHearts3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invHearts3.TabIndex = 17;
            this.invHearts3.TabStop = false;
            // 
            // invHearts2
            // 
            this.invHearts2.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.invHearts2.Location = new System.Drawing.Point(50, 32);
            this.invHearts2.Name = "invHearts2";
            this.invHearts2.Size = new System.Drawing.Size(32, 32);
            this.invHearts2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invHearts2.TabIndex = 16;
            this.invHearts2.TabStop = false;
            // 
            // invHearts1
            // 
            this.invHearts1.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.invHearts1.Location = new System.Drawing.Point(12, 32);
            this.invHearts1.Name = "invHearts1";
            this.invHearts1.Size = new System.Drawing.Size(32, 32);
            this.invHearts1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invHearts1.TabIndex = 15;
            this.invHearts1.TabStop = false;
            // 
            // pbox4
            // 
            this.pbox4.Location = new System.Drawing.Point(416, 401);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(250, 250);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox4.TabIndex = 10;
            this.pbox4.TabStop = false;
            // 
            // pbox3
            // 
            this.pbox3.Location = new System.Drawing.Point(116, 401);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(250, 250);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox3.TabIndex = 9;
            this.pbox3.TabStop = false;
            // 
            // pbox2
            // 
            this.pbox2.Location = new System.Drawing.Point(416, 119);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(250, 250);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox2.TabIndex = 8;
            this.pbox2.TabStop = false;
            // 
            // pbox1
            // 
            this.pbox1.Location = new System.Drawing.Point(116, 119);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(250, 250);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox1.TabIndex = 7;
            this.pbox1.TabStop = false;
            // 
            // invertedGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 681);
            this.Controls.Add(this.invHearts3);
            this.Controls.Add(this.invHearts2);
            this.Controls.Add(this.invHearts1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.pbox4);
            this.Controls.Add(this.pbox3);
            this.Controls.Add(this.pbox2);
            this.Controls.Add(this.pbox1);
            this.Controls.Add(this.lblScore);
            this.Name = "invertedGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invertedGame";
            ((System.ComponentModel.ISupportInitialize)(this.invHearts3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invHearts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invHearts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Timer timerInvGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox invHearts1;
        private System.Windows.Forms.PictureBox invHearts2;
        private System.Windows.Forms.PictureBox invHearts3;
    }
}