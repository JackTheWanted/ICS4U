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
            this.instructions = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nameMessage = new System.Windows.Forms.Label();
            this.heightInstructions = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.ageInstructions = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.heightMessage = new System.Windows.Forms.Label();
            this.ageMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(173, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 20);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(4, 45);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(118, 13);
            this.instructions.TabIndex = 1;
            this.instructions.Text = "Please enter your name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // nameMessage
            // 
            this.nameMessage.AutoSize = true;
            this.nameMessage.Location = new System.Drawing.Point(265, 45);
            this.nameMessage.Name = "nameMessage";
            this.nameMessage.Size = new System.Drawing.Size(0, 13);
            this.nameMessage.TabIndex = 3;
            // 
            // heightInstructions
            // 
            this.heightInstructions.AutoSize = true;
            this.heightInstructions.Location = new System.Drawing.Point(4, 77);
            this.heightInstructions.Name = "heightInstructions";
            this.heightInstructions.Size = new System.Drawing.Size(143, 13);
            this.heightInstructions.TabIndex = 4;
            this.heightInstructions.Text = "Please enter your height in m";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(159, 77);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // ageInstructions
            // 
            this.ageInstructions.AutoSize = true;
            this.ageInstructions.Location = new System.Drawing.Point(4, 108);
            this.ageInstructions.Name = "ageInstructions";
            this.ageInstructions.Size = new System.Drawing.Size(110, 13);
            this.ageInstructions.TabIndex = 6;
            this.ageInstructions.Text = "Please enter your age";
            this.ageInstructions.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(159, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // heightMessage
            // 
            this.heightMessage.AutoSize = true;
            this.heightMessage.Location = new System.Drawing.Point(268, 83);
            this.heightMessage.Name = "heightMessage";
            this.heightMessage.Size = new System.Drawing.Size(0, 13);
            this.heightMessage.TabIndex = 8;
            // 
            // ageMessage
            // 
            this.ageMessage.AutoSize = true;
            this.ageMessage.Location = new System.Drawing.Point(268, 111);
            this.ageMessage.Name = "ageMessage";
            this.ageMessage.Size = new System.Drawing.Size(0, 13);
            this.ageMessage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 363);
            this.Controls.Add(this.ageMessage);
            this.Controls.Add(this.heightMessage);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.ageInstructions);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.heightInstructions);
            this.Controls.Add(this.nameMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label nameMessage;
        private System.Windows.Forms.Label heightInstructions;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label ageInstructions;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label heightMessage;
        private System.Windows.Forms.Label ageMessage;
    }
}

