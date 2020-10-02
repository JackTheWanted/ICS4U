using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intClick_Click(object sender, EventArgs e)
        {
            if (maximum.Value <= minimum.Value)
            {
                randomOutput.Text = "Please select a larger maximum";
            }

            else if (maximum.Value > minimum.Value)
            {
                int randomInt = generator.Next((int)minimum.Value, (int)maximum.Value + 1);
                randomOutput.Text = randomInt + "";
            }
                
        }

        private void doubleClick_Click(object sender, EventArgs e)
        {
            if (maximum.Value <= minimum.Value)
            {
                randomOutput.Text = "Please select a larger maximum";
            }

            else if (maximum.Value > minimum.Value)
            {
                double randomDouble = generator.NextDouble() * ((int)maximum.Value - (int)minimum.Value) + (int)minimum.Value;
                randomOutput.Text = randomDouble + "";
            }
            
        }
    }
}
