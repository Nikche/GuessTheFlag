using System;

namespace Guess_The_Flag
{
    partial class ClassicGame
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
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblInARow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.csHearts1 = new System.Windows.Forms.PictureBox();
            this.csHearts2 = new System.Windows.Forms.PictureBox();
            this.csHearts3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.Location = new System.Drawing.Point(33, 328);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(353, 58);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "New Game";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.Location = new System.Drawing.Point(416, 328);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(352, 58);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "New Game";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.Location = new System.Drawing.Point(33, 412);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(353, 58);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "New Game";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.Location = new System.Drawing.Point(416, 412);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(352, 58);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "New Game";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(94, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Total Score:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(645, 9);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 20);
            this.lblTimeLeft.TabIndex = 6;
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Enabled = true;
            this.timerTimeLeft.Interval = 1000;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(103, 9);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(0, 20);
            this.lblTotalScore.TabIndex = 7;
            // 
            // lblInARow
            // 
            this.lblInARow.AutoSize = true;
            this.lblInARow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInARow.Location = new System.Drawing.Point(285, 9);
            this.lblInARow.Name = "lblInARow";
            this.lblInARow.Size = new System.Drawing.Size(0, 20);
            this.lblInARow.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // csHearts1
            // 
            this.csHearts1.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.csHearts1.Location = new System.Drawing.Point(16, 32);
            this.csHearts1.Name = "csHearts1";
            this.csHearts1.Size = new System.Drawing.Size(32, 32);
            this.csHearts1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.csHearts1.TabIndex = 18;
            this.csHearts1.TabStop = false;
            // 
            // csHearts2
            // 
            this.csHearts2.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.csHearts2.Location = new System.Drawing.Point(54, 32);
            this.csHearts2.Name = "csHearts2";
            this.csHearts2.Size = new System.Drawing.Size(32, 32);
            this.csHearts2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.csHearts2.TabIndex = 19;
            this.csHearts2.TabStop = false;
            // 
            // csHearts3
            // 
            this.csHearts3.Image = global::Guess_The_Flag.Properties.Resources.heart;
            this.csHearts3.Location = new System.Drawing.Point(92, 32);
            this.csHearts3.Name = "csHearts3";
            this.csHearts3.Size = new System.Drawing.Size(32, 32);
            this.csHearts3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.csHearts3.TabIndex = 20;
            this.csHearts3.TabStop = false;
            // 
            // ClassicGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.csHearts3);
            this.Controls.Add(this.csHearts2);
            this.Controls.Add(this.csHearts1);
            this.Controls.Add(this.lblInARow);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClassicGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassicGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csHearts3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblInARow;
        private System.Windows.Forms.PictureBox csHearts1;
        private System.Windows.Forms.PictureBox csHearts2;
        private System.Windows.Forms.PictureBox csHearts3;
    }
}