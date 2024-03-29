﻿namespace GhostBowling
{
    partial class GhostBowlingForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                soundPlayer.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GhostBowlingForm));
            this.bowl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lose = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.winLose = new System.Windows.Forms.Label();
            this.tryLuck = new System.Windows.Forms.Button();
            this.setTheBall = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bowl
            // 
            this.bowl.BackColor = System.Drawing.SystemColors.Highlight;
            this.bowl.FlatAppearance.BorderSize = 3;
            this.bowl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bowl.Location = new System.Drawing.Point(332, 485);
            this.bowl.Name = "bowl";
            this.bowl.Size = new System.Drawing.Size(231, 57);
            this.bowl.TabIndex = 3;
            this.bowl.Text = "Bowl";
            this.bowl.UseVisualStyleBackColor = false;
            this.bowl.Click += new System.EventHandler(this.Bowl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 371);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message.Location = new System.Drawing.Point(30, 415);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(865, 52);
            this.message.TabIndex = 1;
            this.message.Text = "Welcome to the Ghost Bowling!!";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lose);
            this.panel3.Controls.Add(this.win);
            this.panel3.Controls.Add(this.score);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.totalScore);
            this.panel3.Controls.Add(this.winLose);
            this.panel3.Location = new System.Drawing.Point(624, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 142);
            this.panel3.TabIndex = 8;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lose.Location = new System.Drawing.Point(196, 26);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(16, 17);
            this.lose.TabIndex = 6;
            this.lose.Text = "0";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.win.Location = new System.Drawing.Point(144, 26);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(16, 17);
            this.win.TabIndex = 5;
            this.win.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(168, 93);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(16, 17);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalScore.Location = new System.Drawing.Point(13, 93);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(89, 17);
            this.totalScore.TabIndex = 1;
            this.totalScore.Text = "Total Score :";
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winLose.Location = new System.Drawing.Point(13, 26);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(101, 17);
            this.winLose.TabIndex = 0;
            this.winLose.Text = "Wins / Loses : ";
            // 
            // tryLuck
            // 
            this.tryLuck.BackColor = System.Drawing.SystemColors.Highlight;
            this.tryLuck.FlatAppearance.BorderSize = 3;
            this.tryLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLuck.Location = new System.Drawing.Point(59, 81);
            this.tryLuck.Name = "tryLuck";
            this.tryLuck.Size = new System.Drawing.Size(125, 38);
            this.tryLuck.TabIndex = 4;
            this.tryLuck.Text = "Try Luck";
            this.tryLuck.UseVisualStyleBackColor = false;
            this.tryLuck.Click += new System.EventHandler(this.TryLuck_Click);
            // 
            // setTheBall
            // 
            this.setTheBall.BackColor = System.Drawing.SystemColors.Highlight;
            this.setTheBall.FlatAppearance.BorderSize = 3;
            this.setTheBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTheBall.Location = new System.Drawing.Point(59, 13);
            this.setTheBall.Name = "setTheBall";
            this.setTheBall.Size = new System.Drawing.Size(125, 38);
            this.setTheBall.TabIndex = 0;
            this.setTheBall.Text = "Set The Ball";
            this.setTheBall.UseVisualStyleBackColor = false;
            this.setTheBall.Click += new System.EventHandler(this.SetTheBall_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.Highlight;
            this.playAgain.FlatAppearance.BorderSize = 3;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(59, 151);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(125, 38);
            this.playAgain.TabIndex = 5;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playAgain);
            this.panel2.Controls.Add(this.setTheBall);
            this.panel2.Controls.Add(this.tryLuck);
            this.panel2.Location = new System.Drawing.Point(624, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 213);
            this.panel2.TabIndex = 7;
            // 
            // GhostBowlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bowl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GhostBowlingForm";
            this.Text = "Ghost Bowling";
            this.Load += new System.EventHandler(this.GhostBowlingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bowl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label winLose;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button tryLuck;
        private System.Windows.Forms.Button setTheBall;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Panel panel2;
    }
}

