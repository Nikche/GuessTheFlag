namespace Guess_The_Flag
{
    partial class Form1
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pboxHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(335, 99);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(194, 58);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblText
            // 
            this.lblText.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.MintCream;
            this.lblText.Font = new System.Drawing.Font("MS Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(298, 26);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(267, 34);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "GUESS THE FLAG";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(335, 163);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(194, 58);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pboxHelp
            // 
            this.pboxHelp.Image = global::Guess_The_Flag.Properties.Resources.question_mark1;
            this.pboxHelp.Location = new System.Drawing.Point(811, 12);
            this.pboxHelp.Name = "pboxHelp";
            this.pboxHelp.Size = new System.Drawing.Size(45, 45);
            this.pboxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxHelp.TabIndex = 4;
            this.pboxHelp.TabStop = false;
            this.pboxHelp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_The_Flag.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 482);
            this.Controls.Add(this.pboxHelp);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnNewGame);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Flag";
            ((System.ComponentModel.ISupportInitialize)(this.pboxHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pboxHelp;
    }
}

