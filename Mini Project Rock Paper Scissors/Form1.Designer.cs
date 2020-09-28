namespace Mini_Project_Rock_Paper_Scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.choiceScissors = new System.Windows.Forms.PictureBox();
            this.choicePaper = new System.Windows.Forms.PictureBox();
            this.choiceRock = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.winCount = new System.Windows.Forms.Label();
            this.lossCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choiceScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choicePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "You";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.choiceScissors);
            this.grpPlayerChoice.Controls.Add(this.choicePaper);
            this.grpPlayerChoice.Controls.Add(this.choiceRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(73, 156);
            this.grpPlayerChoice.Margin = new System.Windows.Forms.Padding(2);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Padding = new System.Windows.Forms.Padding(2);
            this.grpPlayerChoice.Size = new System.Drawing.Size(389, 116);
            this.grpPlayerChoice.TabIndex = 10;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Choices";
            // 
            // choiceScissors
            // 
            this.choiceScissors.Image = ((System.Drawing.Image)(resources.GetObject("choiceScissors.Image")));
            this.choiceScissors.Location = new System.Drawing.Point(277, 27);
            this.choiceScissors.Margin = new System.Windows.Forms.Padding(2);
            this.choiceScissors.Name = "choiceScissors";
            this.choiceScissors.Size = new System.Drawing.Size(73, 64);
            this.choiceScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choiceScissors.TabIndex = 9;
            this.choiceScissors.TabStop = false;
            this.choiceScissors.Click += new System.EventHandler(this.scissorsChoice);
            // 
            // choicePaper
            // 
            this.choicePaper.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.paper;
            this.choicePaper.Location = new System.Drawing.Point(154, 27);
            this.choicePaper.Margin = new System.Windows.Forms.Padding(2);
            this.choicePaper.Name = "choicePaper";
            this.choicePaper.Size = new System.Drawing.Size(73, 64);
            this.choicePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choicePaper.TabIndex = 8;
            this.choicePaper.TabStop = false;
            this.choicePaper.Click += new System.EventHandler(this.paperChoice);
            // 
            // choiceRock
            // 
            this.choiceRock.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.rock;
            this.choiceRock.Location = new System.Drawing.Point(36, 27);
            this.choiceRock.Margin = new System.Windows.Forms.Padding(2);
            this.choiceRock.Name = "choiceRock";
            this.choiceRock.Size = new System.Drawing.Size(73, 64);
            this.choiceRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choiceRock.TabIndex = 5;
            this.choiceRock.TabStop = false;
            this.choiceRock.Click += new System.EventHandler(this.rockChoice);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.choosing;
            this.imgPlayer.Location = new System.Drawing.Point(381, 35);
            this.imgPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(131, 98);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.loading;
            this.imgOpponent.Location = new System.Drawing.Point(21, 35);
            this.imgOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(131, 98);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(243, 92);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 21);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // V
            // 
            this.V.FormattingEnabled = true;
            this.V.Location = new System.Drawing.Point(209, 31);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(120, 56);
            this.V.TabIndex = 12;
            this.V.SelectedIndexChanged += new System.EventHandler(this.V_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wins:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Losses:";
            // 
            // winCount
            // 
            this.winCount.AutoSize = true;
            this.winCount.Location = new System.Drawing.Point(265, 35);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(13, 13);
            this.winCount.TabIndex = 15;
            this.winCount.Text = "0";
            // 
            // lossCount
            // 
            this.lossCount.AutoSize = true;
            this.lossCount.Location = new System.Drawing.Point(265, 65);
            this.lossCount.Name = "lossCount";
            this.lossCount.Size = new System.Drawing.Size(13, 13);
            this.lossCount.TabIndex = 16;
            this.lossCount.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 293);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "How To Play Rock Paper Scissors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lossCount);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.V);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.choiceScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choicePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox choiceRock;
        private System.Windows.Forms.PictureBox choicePaper;
        private System.Windows.Forms.PictureBox choiceScissors;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox V;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label winCount;
        private System.Windows.Forms.Label lossCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

