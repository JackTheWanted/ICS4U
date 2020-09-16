namespace Windows_Forms_Practice
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nameMessage = new System.Windows.Forms.Label();
            this.heightMessage = new System.Windows.Forms.Label();
            this.ageMessage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ageSelction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 139);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your name?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "How tall are you in m?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "How old are you?";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(164, 78);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(179, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 6;
            // 
            // nameMessage
            // 
            this.nameMessage.AutoSize = true;
            this.nameMessage.Location = new System.Drawing.Point(350, 45);
            this.nameMessage.Name = "nameMessage";
            this.nameMessage.Size = new System.Drawing.Size(0, 13);
            this.nameMessage.TabIndex = 7;
            // 
            // heightMessage
            // 
            this.heightMessage.AutoSize = true;
            this.heightMessage.Location = new System.Drawing.Point(350, 84);
            this.heightMessage.Name = "heightMessage";
            this.heightMessage.Size = new System.Drawing.Size(0, 13);
            this.heightMessage.TabIndex = 8;
            // 
            // ageMessage
            // 
            this.ageMessage.AutoSize = true;
            this.ageMessage.Location = new System.Drawing.Point(350, 116);
            this.ageMessage.Name = "ageMessage";
            this.ageMessage.Size = new System.Drawing.Size(0, 13);
            this.ageMessage.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(150, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // ageSelction
            // 
            this.ageSelction.Location = new System.Drawing.Point(164, 114);
            this.ageSelction.Name = "ageSelction";
            this.ageSelction.Size = new System.Drawing.Size(179, 20);
            this.ageSelction.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.ageSelction);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ageMessage);
            this.Controls.Add(this.heightMessage);
            this.Controls.Add(this.nameMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageSelction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label nameMessage;
        private System.Windows.Forms.Label heightMessage;
        private System.Windows.Forms.Label ageMessage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown ageSelction;
    }
}

