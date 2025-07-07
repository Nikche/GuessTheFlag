namespace Guess_The_Flag
{
    partial class NewGame
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
            this.btnClassicGame = new System.Windows.Forms.Button();
            this.lblSettingsText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbClassic = new System.Windows.Forms.RadioButton();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.rdbInverted = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxSurvival = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClassicGame
            // 
            this.btnClassicGame.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassicGame.Location = new System.Drawing.Point(84, 195);
            this.btnClassicGame.Name = "btnClassicGame";
            this.btnClassicGame.Size = new System.Drawing.Size(256, 58);
            this.btnClassicGame.TabIndex = 2;
            this.btnClassicGame.Text = "START";
            this.btnClassicGame.UseVisualStyleBackColor = true;
            this.btnClassicGame.Click += new System.EventHandler(this.btnClassicGame_Click);
            // 
            // lblSettingsText
            // 
            this.lblSettingsText.AutoSize = true;
            this.lblSettingsText.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsText.Location = new System.Drawing.Point(58, 9);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(313, 26);
            this.lblSettingsText.TabIndex = 4;
            this.lblSettingsText.Text = "CHOOSE YOUR DIFFICULTY ";
            this.lblSettingsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "AND STYLE OF PLAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Location = new System.Drawing.Point(6, 17);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(48, 17);
            this.rdbEasy.TabIndex = 6;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Text = "Easy";
            this.rdbEasy.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(6, 40);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(62, 17);
            this.rdbMedium.TabIndex = 7;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbClassic
            // 
            this.rdbClassic.AutoSize = true;
            this.rdbClassic.Location = new System.Drawing.Point(6, 19);
            this.rdbClassic.Name = "rdbClassic";
            this.rdbClassic.Size = new System.Drawing.Size(58, 17);
            this.rdbClassic.TabIndex = 8;
            this.rdbClassic.TabStop = true;
            this.rdbClassic.Text = "Classic";
            this.rdbClassic.UseVisualStyleBackColor = true;
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Location = new System.Drawing.Point(6, 62);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(48, 17);
            this.rdbHard.TabIndex = 9;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Hard";
            this.rdbHard.UseVisualStyleBackColor = true;
            // 
            // rdbInverted
            // 
            this.rdbInverted.AutoSize = true;
            this.rdbInverted.Location = new System.Drawing.Point(6, 42);
            this.rdbInverted.Name = "rdbInverted";
            this.rdbInverted.Size = new System.Drawing.Size(64, 17);
            this.rdbInverted.TabIndex = 10;
            this.rdbInverted.TabStop = true;
            this.rdbInverted.Text = "Inverted";
            this.rdbInverted.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbClassic);
            this.groupBox1.Controls.Add(this.rdbInverted);
            this.groupBox1.Location = new System.Drawing.Point(282, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbEasy);
            this.groupBox2.Controls.Add(this.rdbMedium);
            this.groupBox2.Controls.Add(this.rdbHard);
            this.groupBox2.Location = new System.Drawing.Point(38, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 91);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty";
            // 
            // cboxSurvival
            // 
            this.cboxSurvival.AutoSize = true;
            this.cboxSurvival.Location = new System.Drawing.Point(170, 82);
            this.cboxSurvival.Name = "cboxSurvival";
            this.cboxSurvival.Size = new System.Drawing.Size(94, 17);
            this.cboxSurvival.TabIndex = 16;
            this.cboxSurvival.Text = "Survival Mode";
            this.cboxSurvival.UseVisualStyleBackColor = true;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 296);
            this.Controls.Add(this.cboxSurvival);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSettingsText);
            this.Controls.Add(this.btnClassicGame);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClassicGame;
        private System.Windows.Forms.Label lblSettingsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbClassic;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.RadioButton rdbInverted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxSurvival;
    }
}