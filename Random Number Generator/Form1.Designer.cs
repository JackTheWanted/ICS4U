namespace Random_Number_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minimum = new System.Windows.Forms.NumericUpDown();
            this.maximum = new System.Windows.Forms.NumericUpDown();
            this.intClick = new System.Windows.Forms.Button();
            this.doubleClick = new System.Windows.Forms.Button();
            this.randomOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a min and a max number.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum";
            // 
            // minimum
            // 
            this.minimum.Location = new System.Drawing.Point(159, 74);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(296, 20);
            this.minimum.TabIndex = 5;
            // 
            // maximum
            // 
            this.maximum.Location = new System.Drawing.Point(159, 114);
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(296, 20);
            this.maximum.TabIndex = 6;
            // 
            // intClick
            // 
            this.intClick.Location = new System.Drawing.Point(41, 163);
            this.intClick.Name = "intClick";
            this.intClick.Size = new System.Drawing.Size(204, 23);
            this.intClick.TabIndex = 7;
            this.intClick.Text = "Receive Integer";
            this.intClick.UseVisualStyleBackColor = true;
            this.intClick.Click += new System.EventHandler(this.intClick_Click);
            // 
            // doubleClick
            // 
            this.doubleClick.Location = new System.Drawing.Point(251, 163);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(204, 23);
            this.doubleClick.TabIndex = 8;
            this.doubleClick.Text = "Receive Double";
            this.doubleClick.UseVisualStyleBackColor = true;
            this.doubleClick.Click += new System.EventHandler(this.doubleClick_Click);
            // 
            // randomOutput
            // 
            this.randomOutput.AutoSize = true;
            this.randomOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomOutput.Location = new System.Drawing.Point(34, 228);
            this.randomOutput.Name = "randomOutput";
            this.randomOutput.Size = new System.Drawing.Size(0, 37);
            this.randomOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomOutput);
            this.Controls.Add(this.doubleClick);
            this.Controls.Add(this.intClick);
            this.Controls.Add(this.maximum);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minimum;
        private System.Windows.Forms.NumericUpDown maximum;
        private System.Windows.Forms.Button intClick;
        private System.Windows.Forms.Button doubleClick;
        private System.Windows.Forms.Label randomOutput;
    }
}

