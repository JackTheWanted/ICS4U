using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            nameMessage.Text = ($"Greetings {name}! Nice to meet you!");


            double height = Convert.ToDouble(txtHeight.Text);
            double diffHeight = (2.72 - height);
            heightMessage.Text = ($"You are {diffHeight}m shorter than the tallest man in the world.");

            int age = Convert.ToInt32(ageSelction.Value);
            if (age > 82)
            {
                age = age - 82;
                ageMessage.Text = ($"You are {age} years over the average Canadian lifespan.");

            }
            else if (age < 82)
            {
                age = 82 - age;
                 ageMessage.Text = ($"You are {age} years under the average Canadian lifespan.");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
