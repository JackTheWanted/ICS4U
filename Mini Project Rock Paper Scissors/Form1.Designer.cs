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
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choiceScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choicePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "You";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.choiceScissors);
            this.grpPlayerChoice.Controls.Add(this.choicePaper);
            this.grpPlayerChoice.Controls.Add(this.choiceRock);
            this.grpPlayerChoice.Location = new System.Drawing.Point(110, 240);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(583, 179);
            this.grpPlayerChoice.TabIndex = 10;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Choices";
            // 
            // choiceScissors
            // 
            this.choiceScissors.Image = ((System.Drawing.Image)(resources.GetObject("choiceScissors.Image")));
            this.choiceScissors.Location = new System.Drawing.Point(416, 42);
            this.choiceScissors.Name = "choiceScissors";
            this.choiceScissors.Size = new System.Drawing.Size(109, 99);
            this.choiceScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choiceScissors.TabIndex = 9;
            this.choiceScissors.TabStop = false;
            this.choiceScissors.Click += new System.EventHandler(this.scissorsChoice);
            // 
            // choicePaper
            // 
            this.choicePaper.Image = ((System.Drawing.Image)(resources.GetObject("choicePaper.Image")));
            this.choicePaper.Location = new System.Drawing.Point(231, 42);
            this.choicePaper.Name = "choicePaper";
            this.choicePaper.Size = new System.Drawing.Size(109, 99);
            this.choicePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choicePaper.TabIndex = 8;
            this.choicePaper.TabStop = false;
            this.choicePaper.Click += new System.EventHandler(this.paperChoice);
            // 
            // choiceRock
            // 
            this.choiceRock.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.rock;
            this.choiceRock.Location = new System.Drawing.Point(54, 42);
            this.choiceRock.Name = "choiceRock";
            this.choiceRock.Size = new System.Drawing.Size(109, 99);
            this.choiceRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choiceRock.TabIndex = 5;
            this.choiceRock.TabStop = false;
            this.choiceRock.Click += new System.EventHandler(this.rockChoice);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.choosing;
            this.imgPlayer.Location = new System.Drawing.Point(572, 54);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(197, 151);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Mini_Project_Rock_Paper_Scissors.Properties.Resources.loading;
            this.imgOpponent.Location = new System.Drawing.Point(32, 54);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(197, 151);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(365, 121);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(85, 32);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPlayerChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.choiceScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choicePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
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
    }
}

